using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pred.Data;
using Pred.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Pred.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly UserManager<ApplicationUser> _userManager;

        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            _logger = logger;
            _userManager = userManager;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult Music()
        {
            return View();
        }
        public IActionResult Function()
        { return View(); }
        public IActionResult food()
        {
            return View();
        }

        public ActionResult thaidau()
        {
            return PartialView("thaidau");
        }
        public ActionResult thaigiua()
        {
            return PartialView("thaigiua");
        }
        public ActionResult thaicuoi()
        {
            return PartialView("thaicuoi");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public JsonResult getHappyDay()
        {
            var user = _userManager.FindByEmailAsync(User.Identity.Name).Result;; 
            var result = Json(
            user.StartDate, new JsonSerializerOptions
            {
                WriteIndented = true,
            });
            return result;
        }
    }
}
