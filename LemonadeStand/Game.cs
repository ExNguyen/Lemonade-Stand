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
            currentDay = 7;

        }

        // member methods (CAN DO)


    }
}
