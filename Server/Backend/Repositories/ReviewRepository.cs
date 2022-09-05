using Backend.Models;
using Backend.Repositories.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly ApplicationDBContext _context;
        private readonly ILogger<ReviewRepository> _logger;
        public ReviewRepository(ApplicationDBContext context, ILogger<ReviewRepository> logger)
        {
            _context = context;
            _logger = logger;
        }
        public async Task<ReviewsDB> Add(ReviewsDB entity)
        {
            try
            {
                var result = await _context.Reviews.AddAsync(entity);
                return result.Entity;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return null;
        }

        public ReviewsDB Delete(ReviewsDB entity)
        {
            throw new NotImplementedException();
        }

        public ReviewsDB Get(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ReviewsDB>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReviewsDB> GetUserReviews(string userId)
        {
            try
            {
                var result = _context.Reviews.Where(el => el.AuthorId == userId).ToList();
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return null;
        }

        public IEnumerable<ReviewsDB> GetEventReviews(string eventId)
        {
            try
            {
                var result = _context.Reviews.Where(el => el.EventId == eventId).ToList();
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return null;
        }

        public ReviewsDB Update(ReviewsDB entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReviewsDB> GetUserEventReviews(string eventId, string userId)
        {
            try
            {
                var result = _context.Reviews.Where(el => el.EventId == eventId && el.AuthorId == userId).ToList();
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return null;
        }
    }
}
