﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        // member variables (HAS A)
        //public string name;
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;

        // constructor (SPAWNER)
        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
            recipe = new Recipe();
        }

        // member methods (CAN DO)
        public void DisplayInventory()
        {
            Console.WriteLine($"\nYour current inventory consist of:" +
                    $"\n{inventory.lemons.Count} Lemons " +
                    $"\n{inventory.sugarCubes.Count} Sugar Cubes " +
                    $"\n{inventory.cups.Count} Cups" +
                    $"\n{inventory.iceCubes.Count} Ice Cubes");
        }


        
        
        

    }
}
