namespace WeatherAnalytics.Data.Entities
{
    public class MinTemperatureData
    {
        public double MinTemperature { get; set; }
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
    }
}
