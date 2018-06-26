using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        public int iceCubesOnHand;
        public int iceCubeBagsOnHand;
        public int sugarCubesOnHand;
        public int lemonsOnHand;
        public int cupsOnHand;
        Player player;
        Day day;

        public Inventory(Player player, Day day)
        {
            this.player = player;
            this.day = day;
        }

        public void IceOnHand()
        {
            iceCubeBagsOnHand = player.iceCubeBagsPurchased - day.bagsOfIceUsed;
            iceCubesOnHand = player.iceCubesPurchased - day.iceCubesUsed;
        }
        public void LemonOnHand()
        {
            lemonsOnHand = player.lemonsPurchased - day.lemonsUsed;
        }
        public void SugarOnHand()
        {
            sugarCubesOnHand = player.sugarPurchased - day.sugarUsed;
        }
        public void CupsOnHand()
        {
            cupsOnHand = player.cupsPurchased - day.cupsUsed;
        }
    }

}
}
