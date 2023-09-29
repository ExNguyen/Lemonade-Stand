using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Recipe
    {
        // member variables (HAS A)
        public int numberOfLemons;
        public int numberOfSugarCubes;
        public int numberOfIceCubes;
        public double pricePerCup;


        // constructor (SPAWNER)
        public Recipe()
        {
            numberOfLemons = 2;
            numberOfSugarCubes = 4;
            numberOfIceCubes = 10;
            pricePerCup = 1;
        }

        //Member Methods (CAN DO)
        public void DisplayRecipe()
        {
            Console.WriteLine($"\nEach pitcher consists of:" +
                $"\n{numberOfLemons} lemons" +
                $"\n{numberOfSugarCubes} sugar cubes" +
                $"\n{numberOfIceCubes} ice cubes");
        }

        public void ChangeRecipe()
        {
            int newNumberOfLemons = UserInterface.ChangeItemRecipe("lemons");
            numberOfLemons = newNumberOfLemons;

            int newNumberOfSugarCubes = UserInterface.ChangeItemRecipe("sugar cubes");
            numberOfSugarCubes = newNumberOfSugarCubes;

            int newNumberOfIceCubes = UserInterface.ChangeItemRecipe("ice cubes");
            numberOfIceCubes = newNumberOfIceCubes;

            DisplayRecipe();

        }

        public void ChangePricePerCup()
        {
            //Console.WriteLine("How much would you like to charge per cup?");
            //int priceChange = int.Parse(Console.ReadLine());
            bool userInputIsAnInteger = false;
            double priceChange = -1;

            while (!userInputIsAnInteger || priceChange < 0)
            {
                Console.WriteLine("How much would you like to charge per cup?");
                Console.WriteLine("Please enter a positive integer (or 0 to cancel):");

                userInputIsAnInteger = double.TryParse(Console.ReadLine(), out priceChange);
            }

            pricePerCup = priceChange;
            
        }

    }
}
