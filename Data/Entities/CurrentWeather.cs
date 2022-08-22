﻿namespace WeatherAnalytics.Data.Entities
{
    public class CurrentWeather
    {
        public int ID { get; set; } 
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Temperature { get; set; }
        public double WindSpeed { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
