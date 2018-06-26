using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        public int potentialCustomers;
        public int actualCustomers;

        public Day()
        {
            PotentialCustomersGeneration();
            ActualCustomersGeneration();
        }

        public void PotentialCustomersGeneration()
        {
            Random rnd = new Random();
            potentialCustomers = rnd.Next(80, 121);
        }
    }
}
