using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models.Review
{
    public class AddReview
    {
        [Required]
        [Range(0, 5)]
        public float Rate { get; set; }
        [Required]
        public string AuthorId { get; set; }
        [Required]
        public string EventId { get; set; }
    }
}
