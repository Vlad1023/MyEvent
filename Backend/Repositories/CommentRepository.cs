using Backend.Models;
using Backend.Repositories.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly ApplicationDBContext _context;
        private readonly ILogger<CommentRepository> _logger;
        public CommentRepository(ApplicationDBContext context, ILogger<CommentRepository> logger)
        {
            _context = context;
            _logger = logger;
        }
        public async Task<CommentsDB> Add(CommentsDB entity)
        {
            try
            {
                var result = await _context.Comments.AddAsync(entity);
                _context.SaveChanges();
                return result.Entity;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return null;
        }

        public CommentsDB Delete(CommentsDB entity)
        {
            throw new NotImplementedException();
        }

        public CommentsDB Get(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CommentsDB>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CommentsDB> GetEventComments(string eventId)
        {
            try
            {
                var result = _context.Comments.Where(el => el.EventId == eventId);
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return null;
        }

        public CommentsDB Update(CommentsDB entity)
        {
            throw new NotImplementedException();
        }
    }
}
