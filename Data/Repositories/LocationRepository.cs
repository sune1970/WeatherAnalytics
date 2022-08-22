using Microsoft.EntityFrameworkCore;
using WeatherAnalytics.Data.Entities;
using WeatherAnalytics.Data.Repositories.Interfaces;

namespace WeatherAnalytics.Data.Repositories
{
    public class LocationRepository: ILocationRepository
    {
        private readonly WeatherContext _context;

        public LocationRepository(WeatherContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Location>> GetAll()
        {
            return await _context.Locations.ToListAsync();
        }
    }
}
