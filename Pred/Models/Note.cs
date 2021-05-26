using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pred.Models
{
    public class Note
    {
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string userId { get; set; }
        public string tilte { get; set; }
        public string note { get; set; }
        public DateTime dateAdded { get; set; }
    }
}
