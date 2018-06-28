using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Pitcher
    {
        Ice ice;
        Sugar sugar;
        Lemons lemons;
        Cup cup;
        Player player;
        public int cupsPerPitcher;
        
        

        public Pitcher(Player player)
        {
            this.player = player;
            cupsPerPitcher = 8;
            


        }
    }
}
