using WeatherAnalytics.Data.Entities;

namespace WeatherAnalytics.Data.Repositories.Interfaces
{
    public interface IWeatherRepository
    {
        Task<IEnumerable<CurrentWeather>> GetAll();
        Task BulkUpdateCurrentWeather(IEnumerable<CurrentWeather> weatherList);

        Task<List<MinTemperatureData>> GetMinTemperature();
    }
}
