using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class AddEventBasedOnOriginal
    {
        [Required]
        public string EventId { get; set; }
        [Required]
        public string StartDatetime { get; set; }
        [Required]
        public string EndDatetime { get; set; }
        [Required]
        public float Rate { get; set; }
    }
}
