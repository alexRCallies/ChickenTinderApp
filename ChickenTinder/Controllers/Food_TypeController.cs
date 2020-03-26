using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ChickenTinder.Data;
using ChickenTinder.Models;

namespace ChickenTinder.Controllers
{
    public class Food_TypeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Food_TypeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Food_Type
        public async Task<IActionResult> Index()
        {
            return View(await _context.Food_Types.ToListAsync());
        }

        // GET: Food_Type/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var food_Type = await _context.Food_Types
                .FirstOrDefaultAsync(m => m.Id == id);
            if (food_Type == null)
            {
                return NotFound();
            }

            return View(food_Type);
        }

        // GET: Food_Type/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Food_Type/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Food_Type food_Type)
        {
            if (ModelState.IsValid)
            {
                _context.Add(food_Type);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(food_Type);
        }

        // GET: Food_Type/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var food_Type = await _context.Food_Types.FindAsync(id);
            if (food_Type == null)
            {
                return NotFound();
            }
            return View(food_Type);
        }

        // POST: Food_Type/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Food_Type food_Type)
        {
            if (id != food_Type.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(food_Type);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Food_TypeExists(food_Type.Id))
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
            return View(food_Type);
        }

        // GET: Food_Type/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var food_Type = await _context.Food_Types
                .FirstOrDefaultAsync(m => m.Id == id);
            if (food_Type == null)
            {
                return NotFound();
            }

            return View(food_Type);
        }

        // POST: Food_Type/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var food_Type = await _context.Food_Types.FindAsync(id);
            _context.Food_Types.Remove(food_Type);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Food_TypeExists(int id)
        {
            return _context.Food_Types.Any(e => e.Id == id);
        }
    }
}
