using AutoMapper;
using Azure.Storage.Blobs;
using Backend.Models;
using Backend.Models.EventParticipants;
using Backend.Repositories;
using Backend.Services.BlobService;
using Backend.Services.Friends;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Services.Event
{
    public class EventService :  IEventService
    {
        readonly IUnitOfWork _unitOfWork;
        readonly IMapper _mapper;
        readonly IFriendsService _friendService;
        readonly IUserService _userService;

        readonly IBlobService _blobService;

        public EventService(IUnitOfWork _unitOfWork, IMapper _mapper, IFriendsService friendsService, IBlobService blobService, IUserService userService)
        {
            this._unitOfWork = _unitOfWork;
            this._mapper = _mapper;
            this._friendService = friendsService;
            this._blobService = blobService;
            this._userService = userService;
        }

        public async Task<Result<IEnumerable<EventResponce>>> GetAllEvents()
        {
            var events = await _unitOfWork.Events.GetAll();
            var mappedEvents = _mapper.Map<IEnumerable<EventResponce>>(events);
            PopulateParticipants(mappedEvents);
            PopulateParticipants(mappedEvents);
            return Result<IEnumerable<EventResponce>>.GetSuccess(mappedEvents);
        }

        public async Task<Result<IEnumerable<EventResponce>>> GetAllUpcomingEvents(string textToSearch, string userId)
        {
            var events = await _unitOfWork.Events.GetAllUpcomingEvents(textToSearch);
            var mappedEvents = _mapper.Map<IEnumerable<EventResponce>>(events);
            AddReviewsCount(mappedEvents);
            PopulateParticipants(mappedEvents);
            await PopulateAuthorsNames(mappedEvents);
            if (userId != null)
                await AddFriendsParticipantCount(mappedEvents, userId);
            return Result<IEnumerable<EventResponce>>.GetSuccess(mappedEvents);
        }

        public async Task<Result<EventResponce>> AddEvent(AddEvent newEvent)
        {
            var error = ValidateEventTime(DateTime.Parse(newEvent.StartDatetime), DateTime.Parse(newEvent.EndDatetime));
            if (error != null)
                return Result<EventResponce>.GetError(422, error);

            var eventDB = _mapper.Map<EventDB>(newEvent);

            var locationDbModel = _mapper.Map<LocationDB>(newEvent.Location);
            var addedLocation = await _unitOfWork.Locations.Add(locationDbModel);
            eventDB.LocationID = addedLocation.LocationId;


            var container = _blobService.GetEventsBlobContainerClient();
            var imgName = Guid.NewGuid().ToString() + newEvent.Image.FileName;
            await container.UploadBlobAsync(imgName, newEvent.Image.OpenReadStream());
            eventDB.ImagePath = _blobService.PathToContainer + imgName;

            var addedEvent = await _unitOfWork.Events.Add(eventDB);
            _unitOfWork.Complete();

            var mappedEvent = _mapper.Map<EventResponce>(addedEvent);
            PopulateParticipants(mappedEvent);

            return Result<EventResponce>.GetSuccess(mappedEvent);
        }

        public async Task<Result<EventParticipantResponce>> AddEventParticipant(AddEventParticipant newParticipant)
        {
            var mappedEvent = _mapper.Map<EventParticipantsDB>(newParticipant);
            var result = await this._unitOfWork.EventParticipants.Add(mappedEvent);
            this._unitOfWork.Complete();
            return Result<EventParticipantResponce>.GetSuccess(_mapper.Map<EventParticipantResponce>(result));
        }

        public Result<EventParticipantResponce> DeleteEventParticipant(DeleteEventParticipant eventToDelete)
        {
            var eventParticipant = this._unitOfWork.EventParticipants.GetEventParticipantByUserAndEventIds(eventToDelete);
            if (eventParticipant != null)
            {
                var deletedEntity = _unitOfWork.EventParticipants.Delete(eventParticipant);
                this._unitOfWork.Complete();
                return Result<EventParticipantResponce>.GetSuccess(_mapper.Map<EventParticipantResponce>(deletedEntity));
            }
            else
                return Result<EventParticipantResponce>.GetError(404, "Such participant does not exist");
        }

        public Result<LocationResponce> GetEventLocation([FromQuery]string locationId)
        {
            var location = _unitOfWork.Locations.Get(locationId);
            if(location != null)
            {
                return Result<LocationResponce>.GetSuccess(_mapper.Map<LocationResponce>(location));
            }
            return Result<LocationResponce>.GetError(404, "Such location does not exist");
        }

        public async Task<Result<UserEventsResponce>> GetUserEvents(string userId, string textToSearch)
        {
            var userCreatedEvents = await _unitOfWork.Events.GetUserCreatedEvents(userId, textToSearch);
            var userParticipantEvents = await _unitOfWork.Events.GetUserParticipantEvents(userId, textToSearch);
            if (userCreatedEvents == null || userParticipantEvents == null)
                return Result<UserEventsResponce>.GetError(500, "Error during requst");
            var createdEventsMap = _mapper.Map<IEnumerable<EventDB>, IEnumerable<EventResponce>>(userCreatedEvents);
            PopulateParticipants(createdEventsMap);
            AddReviewsCount(createdEventsMap);
            await AddFriendsParticipantCount(createdEventsMap, userId);
            await PopulateAuthorsNames(createdEventsMap);
            var userParticipantsMap = _mapper.Map<IEnumerable<EventDB>, IEnumerable<EventResponce>>(userParticipantEvents);
            PopulateParticipants(userParticipantsMap);
            AddReviewsCount(userParticipantsMap);
            await AddFriendsParticipantCount(userParticipantsMap, userId);
            await PopulateAuthorsNames(userParticipantsMap);
            var userEventResponce = new UserEventsResponce { CreatedEvents = createdEventsMap, ParticipantEvents = userParticipantsMap };
            return Result<UserEventsResponce>.GetSuccess(userEventResponce);
        }

        public async Task<Result<UserFinishedEventsResponce>> GetUserFinishedEvents(string userId, string textToSearch)
        {
            var userFinishedEvents = await _unitOfWork.Events.GetUserFinishedEvents(userId, textToSearch);
            var userCancelledEvents = await _unitOfWork.Events.GetUserCancelledEvents(userId, textToSearch);
            if (userFinishedEvents == null || userCancelledEvents == null)
                return Result<UserFinishedEventsResponce>.GetError(500, "Error during request");
            var userFinishedEventsMap = _mapper.Map<IEnumerable<EventDB>, IEnumerable<EventResponce>>(userFinishedEvents);
            PopulateParticipants(userFinishedEventsMap);
            AddReviewsCount(userFinishedEventsMap);
            await AddFriendsParticipantCount(userFinishedEventsMap, userId);
            await PopulateAuthorsNames(userFinishedEventsMap);
            var userCancelledEventsMap = _mapper.Map<IEnumerable<EventDB>, IEnumerable<EventResponce>>(userCancelledEvents);
            PopulateParticipants(userCancelledEventsMap);
            AddReviewsCount(userCancelledEventsMap);
            await AddFriendsParticipantCount(userCancelledEventsMap, userId);
            await PopulateAuthorsNames(userCancelledEventsMap);
            var userFinishedEventsResponce = new UserFinishedEventsResponce { FinishedEvents = userFinishedEventsMap, CancelledEvents = userCancelledEventsMap };
            return Result<UserFinishedEventsResponce>.GetSuccess(userFinishedEventsResponce);
        }

        public  Result<EventResponce> CancelEvent(string eventId)
        {
            var result = _unitOfWork.Events.CancelEvent(eventId);
            if(result == null)
                return Result<EventResponce>.GetError(404, "Such event does not exist");
            return Result<EventResponce>.GetSuccess(_mapper.Map<EventDB, EventResponce>(result));
        }

        public  Result<EventResponce> UncancelEvent(string eventId)
        {
            var result = _unitOfWork.Events.UncancelEvent(eventId);
            if (result == null)
                return Result<EventResponce>.GetError(404, "Such event does not exist");
            return Result<EventResponce>.GetSuccess(_mapper.Map<EventDB, EventResponce>(result));
        }

        public async Task<Result<EventResponce>> UpdateEvent(UpdateEvent updateEvent)
        {
            var error = ValidateEventTime(DateTime.Parse(updateEvent.StartDatetime), DateTime.Parse(updateEvent.EndDatetime));
            if (error != null)
                return Result<EventResponce>.GetError(422, error);
            var locationDbModel = _mapper.Map<LocationDB>(updateEvent.Location);
            var addedLocation =  await _unitOfWork.Locations.Add(locationDbModel);

            var eventDB = _mapper.Map<EventDB>(updateEvent);
            eventDB.LocationID = addedLocation.LocationId;

            if(updateEvent.Image != null)
            {
                var container = _blobService.GetEventsBlobContainerClient();
                var imgName = Guid.NewGuid().ToString() + updateEvent.Image.FileName;
                await container.UploadBlobAsync(imgName, updateEvent.Image.OpenReadStream());
                eventDB.ImagePath = _blobService.PathToContainer + imgName;
            }

            var updatedEvent = _unitOfWork.Events.Update(eventDB);
            if (updatedEvent == null)
                return Result<EventResponce>.GetError(500, "Error during update");
            _unitOfWork.Complete();

            var mappedEvent = _mapper.Map<EventResponce>(updatedEvent);
            PopulateParticipants(mappedEvent);

            return Result<EventResponce>.GetSuccess(mappedEvent);
        }

        public async Task<Result<IEnumerable<EventResponce>>> GetNearestEvents(double logitude, double latitude, string userId)
        {
            var events = await _unitOfWork.Events.GetNearestEvents(logitude, latitude);
            var mappedEvents = _mapper.Map<IEnumerable<EventResponce>>(events);
            PopulateParticipants(mappedEvents);
            PopulateParticipants(mappedEvents);
            await PopulateAuthorsNames(mappedEvents);
            AddReviewsCount(mappedEvents);
            await AddFriendsParticipantCount(mappedEvents, userId);
            return Result<IEnumerable<EventResponce>>.GetSuccess(mappedEvents);
        }

        public async Task<Result<EventResponce>> AddEventBasedOnOriginal(AddEventBasedOnOriginal newEvent)
        {
            var error = ValidateEventTime(DateTime.Parse(newEvent.StartDatetime), DateTime.Parse(newEvent.EndDatetime));
            if (error != null)
                return Result<EventResponce>.GetError(422, error);
            var existingEvent = _unitOfWork.Events.Get(newEvent.EventId);

            existingEvent.EventId = null;
            existingEvent.OriginalEventId = existingEvent.OriginalEventId ?? newEvent.EventId;
            existingEvent.isFinished = false;
            existingEvent.IsCreatedFromOriginal = true;
            existingEvent.StartDatetime = DateTime.Parse(newEvent.StartDatetime);
            existingEvent.EndDatetime = DateTime.Parse(newEvent.EndDatetime);
            existingEvent.Rate = newEvent.Rate;

            var addedEvent = await _unitOfWork.Events.Add(existingEvent);
            _unitOfWork.Complete();
            return Result<EventResponce>.GetSuccess(_mapper.Map<EventResponce>(addedEvent));
        }

        private string ValidateEventTime(DateTime StartTime, DateTime EndTime)
        {
            var currentTime = DateTime.Now;
            if (StartTime >= EndTime)
            {
                return "End time must be greater than Start one";
            }
            if (currentTime >= StartTime || currentTime >= EndTime)
            {
                return "Start time and End time must be greater than current time";
            }
            return null;
        }

        public void PopulateParticipants(EventResponce eventResponce)
        {
            var result = _unitOfWork.EventParticipants.GetEventParticipants(eventResponce.EventId);
            eventResponce.PariticipantsIds = (ICollection<string>)(result.Select(el => el.UserId).ToList());
        }

        public void PopulateParticipants(IEnumerable<EventResponce> eventResponces)
        {
            foreach (var item in eventResponces)
            {
                var result = _unitOfWork.EventParticipants.GetEventParticipants(item.EventId);
                item.PariticipantsIds = result.Select(el => el.UserId).ToList();
            }
        }

        public async Task PopulateAuthorsNames(IEnumerable<EventResponce> eventResponces)
        {
            foreach (var item in eventResponces)
            {
                var result = await _userService.GetUserById(item.AuthorId);
                item.AuthorName = result.Data.Login;
            }
        }


        private void AddReviewsCount(IEnumerable<EventResponce> mappedEvents)
        {
            foreach (var item in mappedEvents)
            {
                item.ReviewsCount += _unitOfWork.Reviews.GetEventReviews(item.OriginalEventId).Count();
                item.ReviewsCount += _unitOfWork.Reviews.GetEventReviews(item.EventId).Count();
            }
        }

        private async Task AddFriendsParticipantCount(IEnumerable<EventResponce> mappedEvents, string userId)
        {
            var userFriends = await _friendService.GetUserFriends(userId);
            if (userFriends.Data.Any())
            {
                foreach (var item in mappedEvents)
                {
                    var participantsWithAuthor = item.PariticipantsIds.Union(new List<string> { item.AuthorId });
                    item.FriendsParticipantCount = userFriends.Data.Select(el => el.Id).Intersect(participantsWithAuthor).Count();
                }
            }
        }
    }
}
