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
        public int lemonsBeginningInventory;
        public int iceCubesBeginningInventory;
        public int sugarCubesBeginningInventory;
        public int cupsBeginningInventory;

        Player player;
        Day day;

        public Inventory(Player player, Day day)
        {
            this.player = player;
            this.day = day;
        }

        public void IceBeginningInventory()
        {
            try
            {
                iceCubesBeginningInventory = (0 + (player.iceCubesPurchased - day.iceCubesUsed));
            }
            catch
            {
                iceCubesBeginningInventory = 0;
            }
        }
        public void SugarBeginningInventory()
        {
            try
            {
                sugarCubesBeginningInventory = (0 + (player.sugarPurchased - day.sugarUsed));
            }
            catch
            {
                sugarCubesBeginningInventory = 0;
            }
        }
        public void LemonsBeginningInventory()
        {
            try
            {
                lemonsBeginningInventory = (0 + (player.lemonsPurchased - day.lemonsUsed));
            }
            catch
            {
                lemonsBeginningInventory = 0;
            }
        }
        public void CupsBeginningInventory()
        {
            try
            {
                cupsBeginningInventory = (0 + (player.cupsPurchased - day.cupsUsed));
            }
            catch
            {
                lemonsBeginningInventory = 0;
            }
        }
        public void IceOnHand()
        {
            iceCubeBagsOnHand = player.iceCubeBagsPurchased - day.bagsOfIceUsed;
            iceCubesOnHand = (iceCubesBeginningInventory + player.iceCubesPurchased) - day.iceCubesUsed;
        }
        public void LemonOnHand()
        {
            lemonsOnHand = (lemonsBeginningInventory + player.lemonsPurchased) - day.lemonsUsed;
        }
        public void SugarOnHand()
        {
            sugarCubesOnHand = (sugarCubesBeginningInvetory + player.sugarPurchased) - day.sugarUsed;
        }
        public void CupsOnHand()
        {
            cupsOnHand = (cupsBeginningInventory + player.cupsPurchased) - day.cupsUsed;
        }
    }

}

