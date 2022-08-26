using Backend.Models;
using Backend.Repositories.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Repositories
{
    public class LocationRepository : ILocationRepository
    {
        private readonly ApplicationDBContext _context;
        private readonly ILogger<LocationRepository> _logger;
        public LocationRepository(ApplicationDBContext context, ILogger<LocationRepository> logger)
        {
            _context = context;
            _logger = logger;
        }
        public async Task<LocationDB> Add(LocationDB entity)
        {
            try
            {
                var result =  await _context.Locations.AddAsync(entity);
                return result.Entity;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return null;
        }

        public LocationDB Delete(LocationDB entity)
        {
            throw new NotImplementedException();
        }

        public LocationDB Get(string id)
        {
            try
            {
                var result = _context.Locations.Where(el => el.LocationId == id).First();
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return null;
        }

        public Task<IEnumerable<LocationDB>> GetAll()
        {
            throw new NotImplementedException();
        }

        public LocationDB Update(LocationDB entity)
        {
            throw new NotImplementedException();
        }
    }
}
