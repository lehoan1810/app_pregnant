using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pred.Data;
using Pred.Models;

namespace Pred.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles =("Admin"))]
    public class ManageController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<IdentityUser> userManager;

        private readonly ApplicationDbContext _context;

        public ManageController(UserManager<IdentityUser> userManager, ApplicationDbContext context)
        {
            this.userManager = userManager;
            this._context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Doctors()
        {
            var doc = userManager.Users;
            return View(doc);
        }

        public IActionResult Hospitals()
        {
            return View(_context.Hospitals);
        }

        [HttpGet]
        public async Task<IActionResult> AddDoctor(string userId)
        {
            var user = await userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return View("Doctors");
            }
            await userManager.AddToRoleAsync(user, "Doctor");
            return View("Doctors");
        }
        [HttpGet]
        public async Task<IActionResult> RemoveDoctor(string userId)
        {
            var user = await userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return View("Doctors");
            }
            await userManager.RemoveFromRoleAsync(user, "Doctor");
            return View("Doctors");
        }

        [HttpGet]
        public IActionResult AddHospital(string name, float longitude, float latitude)
        {
            if (String.IsNullOrWhiteSpace(name))
                return View("Hospitals");
            Hospital h = new Hospital();
            h.Name = name;
            h.lo = longitude;
            h.la = latitude;
            _context.Hospitals.Add(h);
            _context.SaveChanges();
            return View("Hospital");
        }
    }
}
