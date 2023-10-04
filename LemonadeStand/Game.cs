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
            Console.WriteLine("Welcome to Lemonade Stand Game!");
            
            foreach (Day current in days)
            {
                string currentDayName = dayNames[currentDay];

                Console.WriteLine($"\nDay {currentDay + 1}: {currentDayName}");

                Console.WriteLine($"\nYou have ${player.wallet.Money}");
                
                Console.WriteLine($"\nYour current inventory consist of:" +
                    $"\n{player.inventory.lemons.Count} Lemons " +
                    $"\n{player.inventory.sugarCubes.Count} Sugar Cubes " +
                    $"\n{player.inventory.cups.Count} Cups" +
                    $"\n{player.inventory.iceCubes.Count} Ice Cubes\n");


                Console.WriteLine($"\nTodays forecast: {current.weather.predictedForcast}\n ");

                Store store = new Store();
                store.SellLemons(player: player);
                store.SellSugarCubes(player: player);
                store.SellCups(player: player);
                store.SellIceCubes(player: player);

                Console.WriteLine($"\nYou have ${player.wallet.Money} remaining in your wallet.");

                Recipe recipe = new Recipe();
                recipe.DisplayRecipe();

                string changeRecipe;
                do
                {
                    Console.WriteLine("\nWould you like to change your recipe? Y/N");
                    changeRecipe = Console.ReadLine().ToUpper();
                    if (changeRecipe == "Y")
                    {
                        recipe.ChangeRecipe();
                    }
                    else if (changeRecipe == "N") { }
                    else
                    {
                        Console.WriteLine("Invalid input. Please select Y or N.");
                    }
                } while (changeRecipe != "Y" || changeRecipe != "N");

                recipe.CreatePitchers(player: player);

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
