using Microsoft.EntityFrameworkCore;
using WeatherAnalytics.Data;
using WeatherAnalytics.Data.Entities;
using WeatherAnalytics.Data.Repositories.Interfaces;
using WeatherAnalytics.Services.Interfaces;

namespace WeatherAnalytics.Services
{
    public class LocationService : ILocationService
    {
        private readonly ILocationRepository _locationRepository;

        public LocationService(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }

        public async Task<IEnumerable<Location>> GetLocations()
        {
            return await _locationRepository.GetAll();
        }
    }
}
