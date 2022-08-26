using Backend.Models;
using Backend.Models.Invitation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Services.Friends
{
    public interface IFriendsService
    {
        public Task<Result<FriendsResponce>> AddFriends(AddFriends newFriends);
        public Task<Result<FriendInvitationsDB>> ApproveInvitation(string invitationId);
        public Result<FriendInvitationsDB> RejectInvitation(string invitationId);
        public Task<Result<FriendInvitationsDB>> AddFriendsInvitation(AddFriendInvitations newInvitation);
        public Task<Result<IEnumerable<UserResponse>>> GetUserFriends(string userId);
        public Task<Result<IEnumerable<UserFriendsInvitationResponce>>> GetUserFriendInvitations(string userId);
        public Task<Result<IEnumerable<UserResponse>>> GetSearchedUsers(string currentUserId, string toSearch);
    }
}
