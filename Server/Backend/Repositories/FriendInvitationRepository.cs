using Backend.Models;
using Backend.Repositories.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Repositories
{
    public class FriendInvitationRepository : IFriendInvitationsRepository
    {
        private readonly ApplicationDBContext _context;
        private readonly ILogger<FriendInvitationRepository> _logger;
        public FriendInvitationRepository(ApplicationDBContext context, ILogger<FriendInvitationRepository> logger)
        {
            _context = context;
            _logger = logger;
        }
        public async Task<FriendInvitationsDB> Add(FriendInvitationsDB entity)
        {
            try
            {
                var result = await _context.FriendInvitations.AddAsync(entity);
                return result.Entity;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return null;
        }

        public FriendInvitationsDB ApproveInvitation(string invitationId)
        {
            try
            {
                var result = _context.FriendInvitations.Where(el => el.FriendInvitationId == invitationId).First();
                result.IsConfirmed = true;
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return null;
        }

        public FriendInvitationsDB Delete(FriendInvitationsDB entity)
        {
            throw new NotImplementedException();
        }

        public FriendInvitationsDB Get(string id)
        {
            try
            {
                var result = _context.FriendInvitations.Where(el => el.FriendInvitationId == id).First();
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return null;
        }

        public Task<IEnumerable<FriendInvitationsDB>> GetAll()
        {
            throw new NotImplementedException();
        }


        public IEnumerable<FriendInvitationsDB> GetInvitations(string authorId, string userReceiverId)
        {
            try
            {
                var result = _context.FriendInvitations
                    .Where(el => ((el.AuthorId == authorId && el.UserReceiverId == userReceiverId) ||
                          (el.AuthorId == userReceiverId && el.UserReceiverId == authorId)
                      ))
                    .ToList();
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return null;
        }

        public FriendInvitationsDB RejectInvitation(string invitationId)
        {
            try
            {
                var result = _context.FriendInvitations.Where(el => el.FriendInvitationId == invitationId).First();
                result.IsRejected = true;
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return null;
        }

        public FriendInvitationsDB Update(FriendInvitationsDB entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FriendInvitationsDB> GetUserFriendsInvitations(string userId)
        {
            try
            {
                var result = _context.FriendInvitations.Where(el => el.UserReceiverId == userId && el.IsConfirmed == false && el.IsRejected == false).ToList();
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
