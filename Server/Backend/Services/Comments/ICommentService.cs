using Backend.Models.Comments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Services.Comments
{
    public interface ICommentService
    {
        public Task<Result<CommentResponce>> AddComment(AddComment newComment);
        public Task<Result<IEnumerable<CommentResponce>>> GetEventComments(string eventId);
    }
}
