using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using System.Web.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using Pred.Data;
using Pred.Models;

namespace Pred.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles =("Admin"))]
    public class ManageController : Controller
    {
        //private readonly RoleManager<IdentityRole> roleManager;
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

        [HttpGet]
        public JsonResult getHospitals()
        {
            var hs = Json(_context.Hospitals, new JsonSerializerOptions
            {
                WriteIndented = true,
            }); ;
            return hs;
        }

        [HttpGet]
        public async Task<IActionResult> deleteHospital(int Id)
        {
            var hospital = _context.Hospitals.Find(Id);
            if (hospital == null)
                return View();
            _context.Hospitals.Remove(hospital);
            _context.SaveChanges();
            return RedirectToAction("Hospitals");
        }
    }
}
