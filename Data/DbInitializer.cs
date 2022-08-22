using WeatherAnalytics.Data.Entities;

namespace WeatherAnalytics.Data
{
    public class DbInitializer
    {
        public static void Initialize(WeatherContext context)
        {
            context.Database.EnsureCreated();

            if (context.Locations.Any())
            {
                return;
            }

            var locations = new Location[]
            {
                new Location{City = "Oslo", Country ="Norway", Latitude = 59.9111, Longitude =10.7528 },
                new Location{City = "Bergen", Country ="Norway", Latitude = 60.3925, Longitude =10.4000 },
                new Location{City = "Stavanger", Country ="Norway", Latitude = 58.9701, Longitude =5.7333 },
                new Location{City = "Drammen", Country ="Norway", Latitude = 59.7439, Longitude =10.2045 },
                new Location{City = "Kristiansand", Country ="Norway", Latitude = 58.1467, Longitude =7.9956 },
                new Location{City = "Fredrikstad", Country ="Norway", Latitude = 59.2167, Longitude =10.9500 },
                new Location{City = "Skien", Country ="Norway", Latitude = 59.2096, Longitude =9.6090 },
                new Location{City = "Sandefjord", Country ="Norway", Latitude = 59.1288, Longitude =10.2197 },
                new Location{City = "Asker", Country ="Norway", Latitude =  59.8331, Longitude =10.4392 },
                new Location{City = "Trondheim", Country ="Norway", Latitude = 63.4400, Longitude =10.4000 },

                new Location{City = "Riga", Country ="Latvia", Latitude = 56.9475, Longitude =24.1069 },
                new Location{City = "Daugavpils", Country ="Latvia", Latitude = 55.8714, Longitude =26.5161 },
                new Location{City = "Liepāja", Country ="Latvia", Latitude = 56.5083, Longitude =21.0111 },
                new Location{City = "Jelgava", Country ="Latvia", Latitude = 56.6522, Longitude =23.7244 },
                new Location{City = "Jūrmala", Country ="Latvia", Latitude = 56.9680, Longitude =23.7704},
                new Location{City = "Ventspils", Country ="Latvia", Latitude = 57.3897, Longitude =21.5644 },
                new Location{City = "Rēzekne", Country ="Latvia", Latitude = 56.5067, Longitude =27.3308 },
                new Location{City = "Ogre", Country ="Latvia", Latitude = 56.8169, Longitude =24.6047 },
                new Location{City = "Valmiera", Country ="Latvia", Latitude = 57.5381, Longitude =25.4231 },
                new Location{City = "Jēkabpils", Country ="Latvia", Latitude = 56.4975, Longitude = 25.8664},

                new Location{City = "Anhui", Country ="China", Latitude = 33.2504, Longitude =115.3500 },
                new Location{City = "Beijing", Country ="China", Latitude = 39.5400, Longitude =115.7899 },
                new Location{City = "Chongqing", Country ="China", Latitude = 31.0504, Longitude =109.5166 },
                new Location{City = "Fujian", Country ="China", Latitude = 26.2299, Longitude =117.5800 },
                new Location{City = "Gansu", Country ="China", Latitude = 39.8300, Longitude =97.7299 },
                new Location{City = "Guangdong", Country ="China", Latitude = 23.0799, Longitude =114.3999 },
                new Location{City = "Guangxi", Country ="China", Latitude = 21.9504, Longitude =108.6199 },
                new Location{City = "Guizhou", Country ="China", Latitude = 27.6804, Longitude =109.1300 },
                new Location{City = "Hainan", Country ="China", Latitude = 18.2591, Longitude =109.5040 },
                new Location{City = "Hebei", Country ="China", Latitude = 37.7199, Longitude =115.7000 },

                new Location{City = "Yerevan", Country ="Armenia", Latitude = 40.1814, Longitude =44.5144 },
                new Location{City = "Gyumri", Country ="Armenia", Latitude = 40.7833, Longitude =43.8333},
                new Location{City = "Vanadzor", Country ="Armenia", Latitude = 40.8128, Longitude =44.4883 },
                new Location{City = "Ejmiatsin", Country ="Armenia", Latitude = 40.1728, Longitude =44.2925 },
                new Location{City = "Hrazdan", Country ="Armenia", Latitude = 40.5000, Longitude =44.7667 },
                new Location{City = "Abovyan", Country ="Armenia", Latitude = 40.2739, Longitude =44.6256 },
                new Location{City = "Kapan", Country ="Armenia", Latitude = 39.2011, Longitude =46.4150 },
                new Location{City = "Armavir", Country ="Armenia", Latitude =40.1500, Longitude =44.0400},
                new Location{City = "Charentsavan", Country ="Armenia", Latitude =40.4097, Longitude =44.6431 },
                new Location{City = "Stepanavan", Country ="Armenia", Latitude = 41.0075, Longitude =44.3867 },

                new Location{City = "Delhi", Country ="India", Latitude = 28.6600, Longitude =77.2300 },
                new Location{City = "Mumbai", Country ="India", Latitude = 18.9667, Longitude =72.8333},
                new Location{City = "Kolkāta", Country ="India", Latitude =22.5411, Longitude =88.3378 },
                new Location{City = "Bangalore", Country ="India", Latitude = 12.9699, Longitude =77.5980 },
                new Location{City = "Chennai", Country ="India", Latitude = 13.0825, Longitude =80.2750 },
                new Location{City = "Hyderābād", Country ="India", Latitude = 17.3667, Longitude =78.4667 },
                new Location{City = "Pune", Country ="India", Latitude = 18.5196, Longitude =73.8553 },
                new Location{City = "Ahmedabad", Country ="India", Latitude = 23.0300, Longitude =72.5800 },
                new Location{City = "Sūrat", Country ="India", Latitude = 21.1700, Longitude =72.8300 },
                new Location{City = "Lucknow", Country ="India", Latitude = 26.8470, Longitude =80.9470 },


            };
            foreach (Location loc in locations)
            {
                context.Locations.Add(loc);
            }
            context.SaveChanges();
        }
    }
}
