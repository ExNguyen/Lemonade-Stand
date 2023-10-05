using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        // member variables (HAS A)
        private Player player;
        private List<Day> days;
        private int currentDay;
        string[] dayNames = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        // constructor (SPAWNER)
        public Game()
        {
            player = new Player();
            days = new List<Day>();
            foreach (string dayName in dayNames)
            {
                Day newDay = new Day();
                days.Add(newDay);
            }
            currentDay = 0;
            
        }

        // member methods (CAN DO)
        public void Start()
        {
            UserInterface.DisplayGreeting();
            
            foreach (Day current in days)
            {
                string currentDayName = dayNames[currentDay];

                Console.WriteLine($"\nDay {currentDay + 1}: {currentDayName}");
                Console.WriteLine($"\nYou have ${player.wallet.Money}");

                player.DisplayInventory();
                Console.WriteLine($"\nTodays forecast: {current.weather.predictedForcast}");
                Console.WriteLine($"\nYou have ${player.wallet.Money} remaining in your wallet.");
                
                player.recipe.DisplayRecipe();
                player.recipe.ChangeRecipe();
                player.recipe.CreatePitchers(player: player);

                Console.WriteLine($"Todays weather: {current.weather.temperature} and {current.weather.condition}");

                player.recipe.ChangePricePerCup();
                UserInterface.GenerateCustomers(day: current, player: player);

                Console.WriteLine($"\nYou ended the day with ${player.wallet.Money}.");


                currentDay++;
            }

            Console.WriteLine("Game over!");
            

        }

        
        

    }
}
