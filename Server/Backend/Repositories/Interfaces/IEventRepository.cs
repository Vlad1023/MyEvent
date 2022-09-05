using Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Repositories
{
    public interface IEventRepository : IGenericRepository<EventDB>
    {
        Task<IEnumerable<EventDB>> GetAllUpcomingEvents(string textToSearch);
        Task<IEnumerable<EventDB>> GetUserCancelledEvents(string userId, string textToSearch);
        Task<IEnumerable<EventDB>> GetUserCreatedEvents(string userId, string textToSearch);
        Task<IEnumerable<EventDB>> GetUserParticipantEvents(string userId, string textToSearch);
        Task<IEnumerable<EventDB>> GetUserFinishedEvents(string userId, string textToSearch);
        Task<IEnumerable<EventDB>> GetNearestEvents(double logitude, double latitude);
        EventDB AddRateToEvent(string eventId, float rate);
        EventDB CancelEvent(string eventId);
        EventDB UncancelEvent(string eventId);
        EventDB FinishEvent(string eventId);
    }
}
