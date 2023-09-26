using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Weather
    {
        // member variables (HAS A)
        private static Random random = new Random();

        private List<string> weatherConditions = new List<string>
        {
            "Sunny", "Cloudy", "Rainy",
        };

        // constructor (SPAWNER)
        public Weather()
        {

        }
        

        // member methods (CAN DO)
        public string GetRandomWeather()
        {
             int weatherForDay = random.Next(weatherConditions.Count);
             return weatherConditions[weatherForDay];
        }
    }
}
