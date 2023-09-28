using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Weather
    {
        // member variables (HAS A)
        public string condition;
        public int temperature;
        private List<string> weatherConditions = new List<string>
        {
            "Sunny", "Cloudy", "Rainy",
        };
        public string predictedForcast;

        // constructor (SPAWNER)
        public Weather()
        {
            Random random = new Random();

            int weatherIndex = random.Next(0, weatherConditions.Count);

            condition = weatherConditions[weatherIndex];
            if (condition == "Sunny")
            {
                temperature = random.Next(80, 100);
            }
            else if (condition == "Rainy")
            {
                temperature = random.Next(50, 70);
            }
            else
            {
                temperature = random.Next(65, 80);
            }

            string[] possibleForecasts = new string[]
            {
                "Clear skies and warm temperatures",
                "Expect some showers later in the day",
                "Partly cloudy with mild temperatures",
                "Chance of thunderstorms",
                "Overcast skies with cool temperatures",
                "A mix of sun and clouds"
            };

            int ForecastIndex = random.Next(0, possibleForecasts.Length);
            predictedForcast = possibleForecasts[ForecastIndex];
        }

        // member methods (CAN DO)



    }
}


        
        

