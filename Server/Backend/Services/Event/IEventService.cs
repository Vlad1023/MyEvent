using Backend.Models;
using Backend.Models.EventParticipants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Services.Event
{
    public interface IEventService
    {
        Task<Result<IEnumerable<EventResponce>>> GetAllEvents();
        Task<Result<IEnumerable<EventResponce>>> GetNearestEvents(double logitude, double latitude, string userId);
        Task<Result<IEnumerable<EventResponce>>> GetAllUpcomingEvents(string textToSearch, string userId);
        Task<Result<EventResponce>> AddEvent(AddEvent newEvent);
        Task<Result<EventResponce>> AddEventBasedOnOriginal(AddEventBasedOnOriginal newEvent);
        Task<Result<EventParticipantResponce>> AddEventParticipant(AddEventParticipant newEvent);
        Result<EventParticipantResponce> DeleteEventParticipant(DeleteEventParticipant eventToDelete);
        Result<LocationResponce> GetEventLocation(string locationId);
        Task<Result<UserEventsResponce>> GetUserEvents(string userId, string textToSearch);
        Task<Result<UserFinishedEventsResponce>> GetUserFinishedEvents(string userId, string textToSearch);
        Task<Result<EventResponce>> UpdateEvent(UpdateEvent updateEvent);
        Result<EventResponce> CancelEvent(string eventId);
        Result<EventResponce> UncancelEvent(string eventId);
        void PopulateParticipants(IEnumerable<EventResponce> eventResponces);
        void PopulateParticipants(EventResponce eventResponce);
    }
}
