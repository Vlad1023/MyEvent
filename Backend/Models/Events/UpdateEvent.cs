using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class UpdateEvent
    {
        [Key]
        public string EventId { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "maximum {1} characters allowed for event title")]
        public string EventName { get; set; }
        [Required]
        [MaxLength(1000, ErrorMessage = "maximum {1} characters allowed for event description")]
        public string Description { get; set; }
        [Required]
        public string StartDatetime { get; set; }
        [Required]
        public string EndDatetime { get; set; }
        [Required]
        public UpdateLocation Location { get; set; }
        public IFormFile Image { get; set; }
    }
}
