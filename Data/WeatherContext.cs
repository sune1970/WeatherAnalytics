using Microsoft.EntityFrameworkCore;
using WeatherAnalytics.Data.Entities;

namespace WeatherAnalytics.Data
{
    public class WeatherContext : DbContext
    {
        public WeatherContext(DbContextOptions<WeatherContext> options) : base(options)
        {
        }

        public DbSet<CurrentWeather> CurrentWeather { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Location> CurrentWeatherRaw { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CurrentWeather>().ToTable("CurrentWeather");
            modelBuilder.Entity<Location>().ToTable("Location");
        }
    }
}
