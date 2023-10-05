using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    static class UserInterface
    {
        public static int GetNumberOfItems(string itemsToGet)
        {
            bool userInputIsAnInteger = false;
            int quantityOfItem = -1;

            while (!userInputIsAnInteger || quantityOfItem < 0)
            {
                Console.WriteLine("How many " + itemsToGet + " would you like to buy?");
                Console.WriteLine("Please enter a positive integer (or 0 to cancel):");

                userInputIsAnInteger = Int32.TryParse(Console.ReadLine(), out quantityOfItem);
            }

            return quantityOfItem;
        }
        public static int GetNumberOfPitchers()
        {
            bool userInputIsAnInteger = false;
            int quantityOfItem = -1;

            while (!userInputIsAnInteger || quantityOfItem < 0)
            {
                Console.WriteLine("\nEach pitcher pours 8 cups. How many pitchers would you like to make?");
                Console.WriteLine("Please enter a positive integer (or 0 to cancel):");

                userInputIsAnInteger = Int32.TryParse(Console.ReadLine(), out quantityOfItem);
            }

            return quantityOfItem;
        }

        public static int ChangeItemRecipe(string item)
        {
            bool userInputIsAnInteger = false;
            int quantityOfItem = -1;

            while (!userInputIsAnInteger || quantityOfItem < 0)
            {
                Console.WriteLine("\nHow many " + item + " would you like to put per pitcher?");
                Console.WriteLine("Please enter a positive integer (or 0 to cancel):");

                userInputIsAnInteger = Int32.TryParse(Console.ReadLine(), out quantityOfItem);
            }

            return quantityOfItem;
        }

        public static void GenerateCustomers(Day day, Player player)
        {
            Random random = new Random();
            if (day.weather.condition == "Sunny")
            {
                
                int customerIndex = random.Next(1, 70);
                for (int i = 0; i < customerIndex; i++)
                {
                    Customer customer = new Customer();
                    Console.WriteLine("A customer walks by . . . ");
                    customer.ActAccordingToWeather(day: day, player: player);
                }

            }
            else if (day.weather.condition == "Rainy")
            {
                
                int customerIndex = random.Next(1, 20);
                for (int i = 0; i < customerIndex; i++)
                {
                    Customer customer = new Customer();
                    Console.WriteLine("A customer walks by . . . ");
                    customer.ActAccordingToWeather(day: day, player: player);
                }
            }
            else
            {
                
                int customerIndex = random.Next(1, 40);
                for (int i = 0; i < customerIndex; i++)
                {
                    Customer customer = new Customer();
                    Console.WriteLine("A customer walks by . . . ");
                    customer.ActAccordingToWeather(day: day, player: player);
                }

            }
        }

        public static void VisitStore(Player player)
        {
            Store store = new Store();
            store.SellLemons(player: player);
            store.SellSugarCubes(player: player);
            store.SellCups(player: player);
            store.SellIceCubes(player: player);
        }

        public static void DisplayGreeting()
        {
            Console.WriteLine("Welcome to Lemonade Stand Game! " +
                "\nYou have seven days to make as much money as you can. " +
                "\nThe weather and you price for a cup of lemonade will affect your success. " +
                "\nGood luck and make as much as you can.");
            
        }


    }
}
