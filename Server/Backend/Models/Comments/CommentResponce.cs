using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models.Comments
{
    public class CommentResponce
    {
        public string CommentId { get; set; }
        public DateTime DateAdded { get; set; }
        public string Comment { get; set; }
        public string AuthorName { get; set; }
    }
}
