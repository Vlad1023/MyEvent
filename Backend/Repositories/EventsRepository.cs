using Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Repositories
{
    public class EventsRepository : IEventRepository
    {
        private readonly ApplicationDBContext _context;
        private readonly ILogger<EventsRepository> _logger;
        public EventsRepository(ApplicationDBContext context, ILogger<EventsRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<EventDB> Add(EventDB entity)
        {
            try
            {
                var result = await _context.Events.AddAsync(entity);
                _context.SaveChanges();
                return result.Entity;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return null;
        }

        public EventDB Delete(EventDB entity)
        {
            throw new NotImplementedException();
        }

        public EventDB Get(string id)
        {
            try
            {
                return
                _context.Events.Where(el => el.EventId == id)
                .Include(el => el.Location)
                .First();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return null;
        }

        public async Task<IEnumerable<EventDB>> GetAll()
        {
            return await
            _context.Events
            .Include(el => el.Location)
            .ToListAsync();
        }

        public async Task<IEnumerable<EventDB>> GetAllUpcomingEvents(string textToSearch)
        {
            if (textToSearch != null && textToSearch != "ANY")
            {
                return await
                    _context.Events.Where(el => !el.IsCancelled && !el.isFinished && (el.EventName.Contains(textToSearch) || el.Description.Contains(textToSearch)))
                    .Include(el => el.Location)
                    .ToListAsync();
            }
            return await
            _context.Events.Where(el => !el.IsCancelled && !el.isFinished)
            .Include(el => el.Location)
            .ToListAsync();
        }

        public async Task<IEnumerable<EventDB>> GetUserCreatedEvents(string userId, string textToSearch)
        {
            if (textToSearch != null && textToSearch != "ANY")
            {
                try
                {
                    return await
                    _context.Events.Where(el => el.UserID == userId && !el.IsCancelled && !el.isFinished && (el.EventName.Contains(textToSearch) || el.Description.Contains(textToSearch)))
                    .Include(el => el.Location)
                    .ToListAsync();
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex.Message);
                }
                return null;
            }
            try
            {
                return await
                _context.Events.Where(el => el.UserID == userId && !el.IsCancelled && !el.isFinished).Include(el => el.Location)
                .ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return null;
        }

        public async Task<IEnumerable<EventDB>> GetUserParticipantEvents(string userId, string textToSearch)
        {
            if (textToSearch != null && textToSearch != "ANY")
            {
                try
                {
                    return await
                    _context.Events.Where(el => el.EventParticipants.Any(el => el.UserId == userId) && (el.EventName.Contains(textToSearch) || el.Description.Contains(textToSearch)))
                    .Include(el => el.Location)
                    .ToListAsync();
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex.Message);
                }
                return null;
            }
            try
            {
                return await
                _context.Events.Where(el => el.EventParticipants.Any(el => el.UserId == userId)).Include(el => el.Location)
                .ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return null;

        }

        public async Task<IEnumerable<EventDB>> GetUserFinishedEvents(string userId, string textToSearch)
        {
            if (textToSearch != null && textToSearch != "ANY")
            {
                try
                {
                    return await
                    _context.Events.Where(el => ((el.UserID == userId || el.EventParticipants.Any(el => el.UserId == userId)) && (el.EventName.Contains(textToSearch) || el.Description.Contains(textToSearch)) && el.isFinished))
                    .Include(el => el.Location)
                    .ToListAsync();
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex.Message);
                }
                return null;
            }
            try
            {
                return await
                _context.Events.Where(el => ((el.UserID == userId || el.EventParticipants.Any(el => el.UserId == userId)) && el.isFinished))
                .Include(el => el.Location)
                .ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return null;

        }

        public EventDB Update(EventDB entity)
        {
            try
            {
                var result = this.Get(entity.EventId);
                if (result == null)
                    return null;

                result.EventName = entity.EventName;
                result.Description = entity.Description;
                result.StartDatetime = entity.StartDatetime;
                result.EndDatetime = entity.EndDatetime;
                result.LocationID = entity.LocationID;
                result.ImagePath = entity.ImagePath ?? result.ImagePath;

                _context.SaveChanges();
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return null;
        }

        public async Task<IEnumerable<EventDB>> GetUserCancelledEvents(string userId, string textToSearch)
        {
            if (textToSearch != null && textToSearch != "ANY")
            {
                try
                {
                    return await
                    _context.Events.Where(el => el.UserID == userId && el.IsCancelled && !el.isFinished && (el.EventName.Contains(textToSearch) || el.Description.Contains(textToSearch)))
                    .Include(el => el.Location)
                    .ToListAsync();
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex.Message);
                }
                return null;
            }
            try
            {
                return await
                _context.Events.Where(el => el.UserID == userId && el.IsCancelled && !el.isFinished)
                .Include(el => el.Location)
                .ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return null;

        }

        public EventDB CancelEvent(string eventId)
        {
            try
            {
                var result = this.Get(eventId);
                if (result == null)
                    return null;
                result.IsCancelled = true;
                _context.SaveChanges();
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return null;
        }

        public EventDB UncancelEvent(string eventId)
        {
            try
            {
                var result = this.Get(eventId);
                if (result == null)
                    return null;
                result.IsCancelled = false;
                _context.SaveChanges();
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return null;
        }

        public EventDB AddRateToEvent(string eventId, float rate)
        {
            var eventObj = this.Get(eventId);
            eventObj.Rate = rate;
            _context.SaveChanges();
            return eventObj;
        }

        public EventDB FinishEvent(string eventId)
        {

            try
            {
                var result = this.Get(eventId);
                if (result == null)
                    return null;
                result.isFinished = true;
                _context.SaveChanges();
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return null;
        }

        public async Task<IEnumerable<EventDB>> GetNearestEvents(double logitude, double latitude)
        {
            return await
                this._context.Events.Where(el => Math.Abs(el.Location.Longitude - logitude) <= 0.5 && Math.Abs(el.Location.Latitude - latitude) <= 0.5)
                .Include(el => el.Location)
                .ToListAsync();
        }

    }
}
