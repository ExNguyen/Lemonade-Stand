using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        // member variables (HAS A)
        public List<Lemon> lemons;
        public List<SugarCube> sugarCubes;
        public List<IceCube> iceCubes;
        public List<Cup> cups;
        public List<Lemonade> lemonades;

        // constructor (SPAWNER)
        public Inventory()
        {
            lemons = new List<Lemon>();
            sugarCubes = new List<SugarCube>();
            iceCubes = new List<IceCube>();
            cups = new List<Cup>();
            lemonades = new List<Lemonade>();
            AddLemonsToInventory(20);
            AddSugarCubesToInventory(20);
            AddIceCubesToInventory(100);
            AddCupsToInventory(30);
        }

        // member methods (CAN DO)
        public void AddLemonsToInventory(int numberOfLemons)
        {
            for(int i = 0; i < numberOfLemons; i++)
            {
                Lemon lemon = new Lemon();
                lemons.Add(lemon);
            }
        }

        public void AddSugarCubesToInventory(int numberOfSugarCubes)
        {
            for(int i = 0; i < numberOfSugarCubes; i++)
            {
                SugarCube sugarCube = new SugarCube();
                sugarCubes.Add(sugarCube);
            }
        }

        public void AddIceCubesToInventory(int numberOfIceCubes)
        {
            for(int i = 0; i < numberOfIceCubes; i++)
            {
                IceCube iceCube = new IceCube();
                iceCubes.Add(iceCube);
            }
        }

        public void AddCupsToInventory(int numberOfCups)
        {
            for(int i = 0; i < numberOfCups; i++)
            {
                Cup cup = new Cup();
                cups.Add(cup);
            }
        }
        // Remove Items
        public void RemoveLemonsFromInventory(int numberOfLemons)
        {
            for (int i = 0; i < numberOfLemons; i++)
            {
                    lemons.RemoveAt(0);               
            }
        }

        public void RemoveSugarCubesFromInventory(int numberOfSugarCubes)
        {
            for (int i = 0; i < numberOfSugarCubes; i++)
            {
                sugarCubes.RemoveAt(0);
            }
        }

        public void RemoveIceCubesFromInventory(int numberOfIceCubes)
        {
            for (int i = 0; i < numberOfIceCubes; i++)
            {
                iceCubes.RemoveAt(0);
            }
        }

        public void RemoveCupsFromInventory(int numberOfCups)
        {
            for (int i = 0; i < numberOfCups; i++)
            {
                cups.RemoveAt(0);
            }
        }

        public void AddLemonade(int numberOfLemonade)
        {
            for (int i = 0; i < numberOfLemonade * 8; i++)
            {
                Lemonade lemonade = new Lemonade();
                lemonades.Add(lemonade);
            }
        }

        public void RemoveLemonade(int numberOfLemonade)
        {
            for (int i = 0; i < numberOfLemonade; i++)
                if (lemonades.Count > 0)
                {
                    lemonades.RemoveAt(0);
                }
                else
                {
                    Console.WriteLine("You are out of lemonade!");
                }
        }
    }
}
