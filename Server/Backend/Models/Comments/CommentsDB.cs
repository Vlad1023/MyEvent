using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class CommentsDB
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string CommentId { get; set; }
        public DateTime DateAdded { get; set; }
        public string Comment { get; set; }
        public User Author { get; set; }
        public string AuthorId { get; set; }
        public EventDB Event { get; set; }
        public string EventId { get; set; }
    }
}
