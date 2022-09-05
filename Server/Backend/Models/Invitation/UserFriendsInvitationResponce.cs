using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models.Invitation
{
    public class UserFriendsInvitationResponce
    {
        public string InvitationId { get; set; }
        public string AuthorName { get; set; }
        public string AuthorEmail { get; set; }
    }
}
