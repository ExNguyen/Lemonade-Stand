﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Customer
    {
        // member variables (HAS A)
        public Day day;
        public Wallet wallet;
        private Random random;

        // constructor (SPAWNER)
        public Customer(Day day)
        {
            this.day = day;
            wallet = new Wallet();
            random = new Random();

        }

        // member methods (CAN DO)
        public bool ActAccordingToWeather(string currentWeather, double price)
        {
            double weatherFactor = 1.0;
            if(currentWeather == "Sunny")
            {
                weatherFactor = 1.5;
            }
            else if(currentWeather == "Cloudy")
            {
                weatherFactor = 0.7;
            }
            else if(currentWeather == "Rainy")
            {
                weatherFactor = 0.2;
            }

            Recipe recipe = new Recipe();
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
                Player player = new Player();
                player.wallet.AcceptMoney(recipe.pricePerCup);
                return true;
           }

            return false;
        }
    }
}
