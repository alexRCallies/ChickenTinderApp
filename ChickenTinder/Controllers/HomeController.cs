using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ChickenTinder.Models;
using ChickenTinder.Data;
using System.Security.Claims;

namespace ChickenTinder.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.Users.Where(u => u.Id == userId).FirstOrDefault();
            if (User.IsInRole("Chicken Tinder User"))
            {
                return RedirectToAction("Index", "Chicken_Tinder_User", null);
            }
            else
            {
                return View();
            }
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult FindRestaurant()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
