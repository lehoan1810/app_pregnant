using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pred.Data;
using Pred.Models;

namespace Pred.Controllers
{
    public class HospitalController : Controller
    {

        private readonly ILogger<HomeController> _logger;

        private readonly UserManager<ApplicationUser> _userManager;

        private readonly ApplicationDbContext _context;

        public HospitalController(ILogger<HomeController> logger, UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            _logger = logger;
            _userManager = userManager;
            _context = context;
        }

        public IActionResult Index()
        {
            var hospital = _context.Hospitals;
            return View(hospital);
        }


        [HttpGet]
        public JsonResult getHospitals()
        {
            var hs = Json(_context.Hospitals, new JsonSerializerOptions
            {
                WriteIndented = true,
            });
            return hs;
        }
    }
}
