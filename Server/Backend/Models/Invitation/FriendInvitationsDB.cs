using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class FriendInvitationsDB
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string FriendInvitationId { get; set; }
        public User Author { get; set; }
        public string AuthorId { get; set; }
        public string UserReceiverId { get; set; }
        public bool IsConfirmed { get; set; }
        public bool IsRejected { get; set; }
    }
}
