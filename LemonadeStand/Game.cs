using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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
        

        // constructor (SPAWNER)
        public Game()
        {
            player = new Player();
            days = new List<Day>();
            // Names of the days of the week
            string[] dayNames = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            // Create Day objects for each day of the week
            foreach (string dayName in dayNames)
            {
                Day newDay = new Day();
                newDay.weather.condition = dayName; // Set the day's weather condition to the day name
                days.Add(newDay);
            }
            currentDay = 0;
        }

        // member methods (CAN DO)
        public void Start()
        {
            Console.WriteLine("Welcome to Lemonade Stand Game!");
            
            foreach (Day current in days)
            {

                Console.WriteLine($"\nDay {currentDay + 1} \n Todays predicted forcast is: {current.weather.predictedForcast}");
                Console.WriteLine($"You have ${player.wallet.Money}");
                
                Console.WriteLine($"Your current inventory consist of:" +
                    $"\n{player.inventory.lemons.Count} Lemons " +
                    $"\n{player.inventory.sugarCubes.Count} Sugar Cubes " +
                    $"\n{player.inventory.cups.Count} Cups" +
                    $"\n{player.inventory.iceCubes.Count} Ice Cubes");

                // Your game logic here - allow the player to buy ingredients, set prices, and sell lemonade.
                Store store = new Store();
                store.SellLemons(player: player);
                store.SellSugarCubes(player: player);
                store.SellCups(player: player);
                store.SellIceCubes(player: player);

                Recipe recipe = new Recipe();
                recipe.DisplayRecipe();


                currentDay++; // Move to the next day
            }

            Console.WriteLine("Game over!");
            

        }

        
        

    }
}
