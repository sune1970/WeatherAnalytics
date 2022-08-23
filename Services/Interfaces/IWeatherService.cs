using WeatherAnalytics.Data.Entities;
using WeatherAnalytics.Models;

namespace WeatherAnalytics.Services.Interfaces
{
    public interface IWeatherService
    {
        Task<CurrentWeatherDto> GetCurrentWeather(LocationDTO location);

        Task BulkUpdateCurrentWeatherInfo(List<CurrentWeatherDto> currentWeather);

        Task<List<MinTemperatureModel>> GetMinTemperature();

        Task<IList<MaxWindSpeedModel>> GetMaxWindSpeed();
    }
}
