using Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Repositories.Interfaces
{
    public interface ICommentRepository : IGenericRepository<CommentsDB>
    {
        public IEnumerable<CommentsDB> GetEventComments(string eventId);
    }
}
