using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pred.Models
{
    public class ChatMessage
    {
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string sender { get; set; }
        public string message { get; set; }
        public string group { get; set; }
        public DateTime time { get; set; }
    }
}
