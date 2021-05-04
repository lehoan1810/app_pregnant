using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pred.Data;

namespace Pred.Areas.Admin.Views.Manage
{
    public class DoctorsModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public DoctorsModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {

        }
    }
}
