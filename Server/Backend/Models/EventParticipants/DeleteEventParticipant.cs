using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models.EventParticipants
{
    public class DeleteEventParticipant
    {
        [Required]
        public string UserId { get; set; }
        [Required]
        public string EventId { get; set; }
    }
}
