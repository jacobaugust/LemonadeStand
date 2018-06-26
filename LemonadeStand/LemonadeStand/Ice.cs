using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Ice : Ingredient
    {
        public double bagPrice;
        public int iceCubesInBag;
        public int iceCubes;
        public double cubePrice;

        public Ice()
        {
            cubePrice = 0.02;
            bagPrice = 3.00;
            iceCubesInBag = 150;


        }

        
    }
}
