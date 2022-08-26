using Backend.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class User : IdentityUser
    {
        public ICollection<EventDB> Events { get; set; }

        public ICollection<EventParticipantsDB> EventParticipants { get; set; }
        public ICollection<FriendsDB> Friends { get; set; }
        public ICollection<FriendInvitationsDB> FriendInvitations { get; set; }
        public ICollection<CommentsDB> Comments { get; set; }
        public ICollection<ReviewsDB> Reviews { get; set; }
    }
}
