using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        int iceCubesOnHand;
        int iceCubeBagsOnHand;
        int sugarCubesOnHand;
        int lemonsOnHand;
        int cupsOnHand;
        Player player;

        public Inventory(Player player)
        {
            this.player = player;
        }

        public void IceOnHand()
        {
            iceCubeBagsOnHand = player.iceCubeBagsPurchased - player.bagsOfIceUsed;
            iceCubesOnHand = player.iceCubesPurchased - player.cubesOfIceUsed;
        }
        public void LemonOnHand()
        {
            lemonsOnHand = player.lemonsPurchased - player.lemonsUsed;
        }
        public void SugarOnHand()
        {
            sugarCubesOnHand = player.sugarPurchased - player.sugarUsed;
        }
        public void CupsOnHand()
        {
            cupsOnHand = player.cupsPurchased - player.cupsUsed;
        }
    }

}
}
