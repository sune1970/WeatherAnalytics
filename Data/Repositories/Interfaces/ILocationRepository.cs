using WeatherAnalytics.Data.Entities;

namespace WeatherAnalytics.Data.Repositories.Interfaces
{
    public interface ILocationRepository
    {
        Task<IEnumerable<Location>> GetAll();
    }
}
