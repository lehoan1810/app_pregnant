using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pred.Models
{
    public class ApplicationUser : IdentityUser
    {
        public byte[] ProfilePicture { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public bool Sex { get; set; }
        public string Job { get; set; }
    }
}
