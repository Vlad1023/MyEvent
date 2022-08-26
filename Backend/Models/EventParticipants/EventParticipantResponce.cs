using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models.EventParticipants
{
    public class EventParticipantResponce
    {
        public string EventParticipantsId { get; set; }
        public string EventId { get; set; }
        public string UserId { get; set; }
    }
}
