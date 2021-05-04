using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pred.Data;

namespace Pred.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles =("Admin"))]
    public class ManageController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<IdentityUser> userManager;

        private readonly ApplicationDbContext _context;

        public ManageController(UserManager<IdentityUser> userManager)
        {
            this.userManager = userManager;
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
    }
}
