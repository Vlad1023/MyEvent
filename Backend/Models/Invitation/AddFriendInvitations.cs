using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models.Invitation
{
    public class AddFriendInvitations
    {
        public string AuthorId { get; set; }
        public string UserReceiverId { get; set; }
    }
}
