using Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Repositories.Interfaces
{
    public interface IFriendInvitationsRepository : IGenericRepository<FriendInvitationsDB>
    {
        IEnumerable<FriendInvitationsDB> GetInvitations(string authorId, string userReceiverId);
        IEnumerable<FriendInvitationsDB> GetUserFriendsInvitations(string userId);
        FriendInvitationsDB ApproveInvitation(string invitationId);
        FriendInvitationsDB RejectInvitation(string invitationId);
    }
}
