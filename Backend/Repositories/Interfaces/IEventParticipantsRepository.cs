using Backend.Models;
using Backend.Models.EventParticipants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Repositories.Interfaces
{
    public interface IEventParticipantsRepository : IGenericRepository<EventParticipantsDB>
    {
        IEnumerable<EventParticipantsDB> GetEventParticipants(string eventId);
        EventParticipantsDB GetEventParticipantByUserAndEventIds(DeleteEventParticipant deleteEventParticipant);
    }
}
