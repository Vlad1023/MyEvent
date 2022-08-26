using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models.Comments
{
    public class AddComment
    {
        [MaxLength(100, ErrorMessage = "maximum {1} characters allowed for comment")]
        public string Comment { get; set; } 
        public string AuthorId { get; set; }
        public string EventId { get; set; }
    }
}
