using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class ReviewsDB
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ReviewId { get; set; }
        [Range(0,5)]
        public int Rate { get; set; }
        public User Author { get; set; }
        public string AuthorId { get; set; }
        public EventDB Event { get; set; }
        public string EventId { get; set; }
    }
}
