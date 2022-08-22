using Microsoft.EntityFrameworkCore;
using WeatherAnalytics.Data.Entities;
using WeatherAnalytics.Data.Repositories.Interfaces;

namespace WeatherAnalytics.Data.Repositories
{
    public class WeatherRepository : IWeatherRepository
    {
        private readonly WeatherContext _weatherContext;

        public WeatherRepository(WeatherContext weatherContext)
        {
            _weatherContext = weatherContext;
        }

        public Task<IEnumerable<CurrentWeather>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task BulkUpdateCurrentWeather(IEnumerable<CurrentWeather> weatherList)
        {
            _weatherContext.CurrentWeather.AddRange(weatherList);
            await _weatherContext.SaveChangesAsync();
        }

        public async Task<List<MinTemperatureData>> GetMinTemperature()
        {
            var data = (from p in _weatherContext.CurrentWeather
                        group p by new { p.Country, p.City } into g
                        select new MinTemperatureData
                        {
                            City = g.Key.City,
                            Country = g.Key.Country,
                            MinTemperature = g.Min(c => c.Temperature)
                        }).ToList();

            return data;
        }
    }
}
