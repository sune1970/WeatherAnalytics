using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WeatherAnalytics.Data.Entities;
using WeatherAnalytics.Models;
using WeatherAnalytics.Services.Interfaces;

namespace WeatherAnalytics.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWeatherService _weatherService;
        private readonly ILocationService _locationService;


        public HomeController(ILogger<HomeController> logger, IWeatherService weatherService, ILocationService locationService)
        {
            _logger = logger;
            _weatherService = weatherService;
            _locationService = locationService;
        }

        public async Task<IActionResult> Forecast()
        {
            var locations = await _locationService.GetLocations();
            var currentWeatherDTOs = new List<CurrentWeatherDto>();

            var locationDtos = locations.Select(l =>
                new LocationDTO
                {
                    lat = l.Latitude,
                    country = l.Country,
                    lon = l.Longitude,
                    state = l.Country
                });

            foreach (var loc in locationDtos)
            {
                var data = await _weatherService.GetCurrentWeather(loc);
                currentWeatherDTOs.Add(data);
            }

            await _weatherService.BulkUpdateCurrentWeatherInfo(currentWeatherDTOs);

            return Json(currentWeatherDTOs);
        }

        public async Task<IActionResult> MinTemperature()
        {
            var data = await _weatherService.GetMinTemperature();
            return Json(data);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}