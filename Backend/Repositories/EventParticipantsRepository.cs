using Backend.Models;
using Backend.Models.EventParticipants;
using Backend.Repositories.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Repositories
{
    public class EventParticipantsRepository : IEventParticipantsRepository
    {
        private readonly ApplicationDBContext _context;
        private readonly ILogger<EventParticipantsRepository> _logger;
        public EventParticipantsRepository(ApplicationDBContext context, ILogger<EventParticipantsRepository> logger)
        {
            _context = context;
            _logger = logger;
        }
        public async Task<EventParticipantsDB> Add(EventParticipantsDB entity)
        {
            try
            {
                var result = await _context.EventParticipants.AddAsync(entity);
                return result.Entity;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return null;
        }

        public EventParticipantsDB Delete(EventParticipantsDB entity)
        {
            try
            {
                var result = _context.EventParticipants.Where(el => el.EventParticipantsId == entity.EventParticipantsId).First();
                _context.EventParticipants.Remove(result);
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return null;
        }

        public EventParticipantsDB Get(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EventParticipantsDB>> GetAll()
        {
            throw new NotImplementedException();
        }

        public EventParticipantsDB GetEventParticipantByUserAndEventIds(DeleteEventParticipant deleteEventParticipant)
        {
            try
            {
                var result = _context.EventParticipants.Where(el => el.EventId == deleteEventParticipant.EventId && el.UserId == deleteEventParticipant.UserId).First();
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return null;
        }

        public IEnumerable<EventParticipantsDB> GetEventParticipants(string eventId)
        {
            try
            {
                var result =  _context.EventParticipants.Where(el => el.EventId == eventId);
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return null;
        }

        public EventParticipantsDB Update(EventParticipantsDB entity)
        {
            throw new NotImplementedException();
        }
    }
}
