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
        private Weather weather;

        // constructor (SPAWNER)
        public Game()
        {
            player = new Player();
            days = new List<Day>();
            currentDay = 0;
            weather = Weather();

        }

        // member methods (CAN DO)
        public void Start()
        {
            Console.WriteLine("Welcome to Lemonade Stand Game!");
            while (currentDay < days.Count)
            {
                Day current = days[currentDay];
                Console.WriteLine($"\nDay {currentDay + 1}: {current.WeatherCondition}");

                

                // Your game logic here - allow the player to buy ingredients, set prices, and sell lemonade.

                currentDay++; // Move to the next day
            }

            Console.WriteLine("Game over!");
        }

        // Add a new day with random weather to the game.
        public void AddDay()
        {
            Day newDay = new Day();
            days.Add(newDay);
        }

    }
}
