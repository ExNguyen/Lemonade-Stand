using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Customer
    {
        // member variables (HAS A)
        public Wallet wallet;
        private Random random;

        // constructor (SPAWNER)
        public Customer()
        {
            wallet = new Wallet();
            random = new Random();
        }

        // member methods (CAN DO)
        public bool ActAccordingToWeather(Day day, Recipe recipe, Player player)
        {
            double weatherFactor = 1.0;
            if(day.weather.condition == "Sunny")
            {
                weatherFactor = 1.5;
            }
            else if(day.weather.condition == "Cloudy")
            {
                weatherFactor = 0.7;
            }
            else if(day.weather.condition == "Rainy")
            {
                weatherFactor = 0.2;
            }

            double priceFactor = 1.0;
            if (recipe.pricePerCup > 1.0)
            {
                priceFactor = 0.8;
            }

            double probability = weatherFactor * priceFactor;
            

           if(random.NextDouble() < probability)
           {
                if (wallet.Money > recipe.pricePerCup)
                Console.WriteLine("Customer bought a cup of lemonade!");
                player.inventory.RemoveLemonade(1);
                
                player.wallet.AcceptMoney(recipe.pricePerCup);
                return true;
           }

            return false;
        }
    }
}
