using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        // member variables (HAS A)
        public Weather weather;
        public List<Customer> customers;

        // constructor (SPAWNER)
        public Day()
        {
            weather = new Weather();
            customers = new List<Customer>();
        }

        // member methods (CAN DO)
        
        
    }
}
