using AutoMapper;
using Backend.Models;
using Backend.Models.Invitation;
using Backend.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Services.Friends
{
    public class FriendsService : IFriendsService
    {
        readonly IUnitOfWork _unitOfWork;
        readonly IMapper _mapper;
        readonly IUserService _userService;
        public FriendsService(IUnitOfWork unitOfWork, IMapper mapper, IUserService userService)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
            this._userService = userService;
        }

        public async Task<Result<IEnumerable<UserResponse>>> GetUserFriends(string userId)
        {
            var friendsDB =  _unitOfWork.Friends.GetUserFriends(userId);
            var friends = new List<UserResponse>();
            foreach (var item in friendsDB)
            {
                if(item.UserId == userId)
                {
                    var friend = await _userService.GetUserById(item.UserFriendId);
                    friends.Add(new UserResponse { Email = friend.Data.Email, Login = friend.Data.Login, Id = friend.Data.Id });
                }
                else
                {
                    var friend = await _userService.GetUserById(item.UserId);
                    friends.Add(new UserResponse { Email = friend.Data.Email, Login = friend.Data.Login, Id = friend.Data.Id });
                }

            }
            return Result<IEnumerable<UserResponse>>.GetSuccess(friends);
        }

        public async Task<Result<FriendsResponce>> AddFriends(AddFriends newFriends)
        {
            var friendsDB = await _unitOfWork.Friends.Add(_mapper.Map<FriendsDB>(newFriends));
            _unitOfWork.Complete();
            return Result<FriendsResponce>.GetSuccess(_mapper.Map<FriendsResponce>(friendsDB));
        }

        public async Task<Result<FriendInvitationsDB>> AddFriendsInvitation(AddFriendInvitations newInvitation)
        {
            var existingInvitations =_unitOfWork.FriendsInvitations.GetInvitations(newInvitation.AuthorId, newInvitation.UserReceiverId);
            if (existingInvitations.Any())
                return Result<FriendInvitationsDB>.GetError(500, "Invitation already exists");
            var friendsInvitationDB = await _unitOfWork.FriendsInvitations.Add(_mapper.Map<FriendInvitationsDB>(newInvitation));
            _unitOfWork.Complete();
            return Result<FriendInvitationsDB>.GetSuccess(friendsInvitationDB);
        }

        public async Task<Result<FriendInvitationsDB>> ApproveInvitation(string invitationId)
        {
            if(_unitOfWork.FriendsInvitations.Get(invitationId) == null)
                return Result<FriendInvitationsDB>.GetError(500, "Invitation does not exist");
            var result = _unitOfWork.FriendsInvitations.ApproveInvitation(invitationId);
            await this.AddFriends(new AddFriends { firstUserId = result.AuthorId, secondUserId = result.UserReceiverId });
            _unitOfWork.Complete();
            return Result<FriendInvitationsDB>.GetSuccess(result);
        }

        public Result<FriendInvitationsDB> RejectInvitation(string invitationId)
        {
            if (_unitOfWork.FriendsInvitations.Get(invitationId) == null)
                return Result<FriendInvitationsDB>.GetError(500, "Invitation does not exist");
            var result = _unitOfWork.FriendsInvitations.RejectInvitation(invitationId);
            _unitOfWork.Complete();
            return Result<FriendInvitationsDB>.GetSuccess(result);
        }

        public async Task<Result<IEnumerable<UserResponse>>> GetSearchedUsers(string currentUserId, string toSearch)
        {
            var foundUsers = await _userService.GetUsersBySring(toSearch);
            var result = new List<UserResponse>();
            foreach (var item in foundUsers.Data)
            {
                if (!_unitOfWork.FriendsInvitations.GetInvitations(currentUserId, item.Id).Any() && item.Id != currentUserId)
                {
                    result.Add(item);
                }
            }
            return Result<IEnumerable<UserResponse>>.GetSuccess(result);
        }

        public async Task<Result<IEnumerable<UserFriendsInvitationResponce>>> GetUserFriendInvitations(string userId)
        {
           var invitations = _unitOfWork.FriendsInvitations.GetUserFriendsInvitations(userId);
           var result = new List<UserFriendsInvitationResponce>();
           foreach (var item in invitations)
           {
                var foundUser = await _userService.GetUserById(item.AuthorId);
                var invitationResponce = _mapper.Map<UserFriendsInvitationResponce>(foundUser.Data);
                invitationResponce.InvitationId = item.FriendInvitationId;
                result.Add(invitationResponce);
           }
            return Result<IEnumerable<UserFriendsInvitationResponce>>.GetSuccess(result);
        }
    }
}
