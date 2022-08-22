using WeatherAnalytics.Data.Entities;

namespace WeatherAnalytics.Services.Interfaces
{
    public interface ILocationService
    {
        Task<IEnumerable<Location>> GetLocations();
    }
}
