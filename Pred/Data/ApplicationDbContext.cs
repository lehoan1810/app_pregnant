using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pred.Models;

namespace Pred.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<ChatMessage> chatMessages { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Pred.Models.Meal> Meal { get; set; }
        public DbSet<Pred.Models.Note> Note { get; set; }
    }
}
