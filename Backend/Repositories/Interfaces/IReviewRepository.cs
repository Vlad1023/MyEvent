using Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Repositories.Interfaces
{
    public interface IReviewRepository : IGenericRepository<ReviewsDB>
    {
        public IEnumerable<ReviewsDB> GetUserReviews(string userId);
        public IEnumerable<ReviewsDB> GetEventReviews(string eventId);
        public IEnumerable<ReviewsDB> GetUserEventReviews(string eventId, string userId);
    }
}
