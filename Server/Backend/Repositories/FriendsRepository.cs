using Backend.Models;
using Backend.Repositories.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Repositories
{
    public class FriendsRepository : IFriendRepository
    {
        private readonly ApplicationDBContext _context;
        private readonly ILogger<FriendsRepository> _logger;
        public FriendsRepository(ApplicationDBContext context, ILogger<FriendsRepository> logger)
        {
            _context = context;
            _logger = logger;
        }
        public async Task<FriendsDB> Add(FriendsDB entity)
        {
            try
            {
                var result = await _context.Friends.AddAsync(entity);
                return result.Entity;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return null;
        }

        public FriendsDB Delete(FriendsDB entity)
        {
            throw new NotImplementedException();
        }

        public FriendsDB Get(string id)
        {
            try
            {
                var result = _context.Friends.Where(el => el.UserFriendId == id).First();
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return null;
        }

        public Task<IEnumerable<FriendsDB>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FriendsDB> GetUserFriends(string userId)
        {
            try
            {
                var result = _context.Friends.Where(el => el.UserFriendId == userId || el.UserId == userId).ToList();
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return null;
        }

        public FriendsDB Update(FriendsDB entity)
        {
            throw new NotImplementedException();
        }
    }
}
