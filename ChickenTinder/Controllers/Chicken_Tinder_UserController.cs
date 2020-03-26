using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ChickenTinder.Data;
using ChickenTinder.Models;
using System.Security.Claims;

namespace ChickenTinder.Controllers
{
    public class Chicken_Tinder_UserController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Chicken_Tinder_UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Chicken_Tinder_User
        public IActionResult Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.Chicken_Tinder_Users.Where(x => x.IdentityUserId == userId).FirstOrDefault();
            return View(user);
        }

        // GET: Chicken_Tinder_User/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chicken_Tinder_User = await _context.Chicken_Tinder_Users
                .Include(c => c.Food_Type)
                .Include(c => c.IdentityUser)
                .Include(c => c.Restaurant)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (chicken_Tinder_User == null)
            {
                return NotFound();
            }

            return View(chicken_Tinder_User);
        }

        // GET: Chicken_Tinder_User/Create
        public IActionResult Create()
        {
            ViewData["Food_TypeId"] = new SelectList(_context.Food_Types, "Id", "Id");
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
            ViewData["RestaurantId"] = new SelectList(_context.Restaurants, "Id", "Id");
            return View();
        }

        // POST: Chicken_Tinder_User/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Chicken_Tinder_User chicken_Tinder_User)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                chicken_Tinder_User.IdentityUserId = userId;
                _context.Add(chicken_Tinder_User);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Food_TypeId"] = new SelectList(_context.Food_Types, "Id", "Id", chicken_Tinder_User.Food_TypeId);
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", chicken_Tinder_User.IdentityUserId);
            ViewData["RestaurantId"] = new SelectList(_context.Restaurants, "Id", "Id", chicken_Tinder_User.RestaurantId);
            return View(chicken_Tinder_User);
        }

        // GET: Chicken_Tinder_User/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chicken_Tinder_User = await _context.Chicken_Tinder_Users.FindAsync(id);
            if (chicken_Tinder_User == null)
            {
                return NotFound();
            }
            ViewData["Food_TypeId"] = new SelectList(_context.Food_Types, "Id", "Id", chicken_Tinder_User.Food_TypeId);
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", chicken_Tinder_User.IdentityUserId);
            ViewData["RestaurantId"] = new SelectList(_context.Restaurants, "Id", "Id", chicken_Tinder_User.RestaurantId);
            return View(chicken_Tinder_User);
        }

        // POST: Chicken_Tinder_User/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,PhoneNumber,Address,IdentityUserId,RestaurantId,Food_TypeId")] Chicken_Tinder_User chicken_Tinder_User)
        {
            if (id != chicken_Tinder_User.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chicken_Tinder_User);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Chicken_Tinder_UserExists(chicken_Tinder_User.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["Food_TypeId"] = new SelectList(_context.Food_Types, "Id", "Id", chicken_Tinder_User.Food_TypeId);
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", chicken_Tinder_User.IdentityUserId);
            ViewData["RestaurantId"] = new SelectList(_context.Restaurants, "Id", "Id", chicken_Tinder_User.RestaurantId);
            return View(chicken_Tinder_User);
        }

        // GET: Chicken_Tinder_User/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chicken_Tinder_User = await _context.Chicken_Tinder_Users
                .Include(c => c.Food_Type)
                .Include(c => c.IdentityUser)
                .Include(c => c.Restaurant)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (chicken_Tinder_User == null)
            {
                return NotFound();
            }

            return View(chicken_Tinder_User);
        }

        // POST: Chicken_Tinder_User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var chicken_Tinder_User = await _context.Chicken_Tinder_Users.FindAsync(id);
            _context.Chicken_Tinder_Users.Remove(chicken_Tinder_User);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Chicken_Tinder_UserExists(int id)
        {
            return _context.Chicken_Tinder_Users.Any(e => e.Id == id);
        }
        public IActionResult CreateGroup()
        {
            return RedirectToAction("Create", "Group");
        }
        public IActionResult FindAPlaceToEat()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.Chicken_Tinder_Users.Where(x => x.IdentityUserId == userId).FirstOrDefault();
            return View(user);
        }

    }
}
