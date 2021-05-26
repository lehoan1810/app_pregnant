using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pred.Data;
using Pred.Models;

namespace Pred.Views
{
    public class IndexModel : PageModel
    {
        private readonly Pred.Data.ApplicationDbContext _context;

        public IndexModel(Pred.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Note> Note { get;set; }

        public async Task OnGetAsync()
        {
            Note = await _context.Note.ToListAsync();
        }
    }
}
