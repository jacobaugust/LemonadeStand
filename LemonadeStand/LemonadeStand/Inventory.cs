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
                iceCubesBeginningInventory = player.iceCubesPurchased;
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
                sugarCubesBeginningInventory = player.sugarPurchased;
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
                lemonsBeginningInventory = player.lemonsPurchased;
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
                cupsBeginningInventory = player.cupsPurchased;
            }
        }
        public void IceOnHand(int iceCubesUsed)
        {
            iceCubeBagsOnHand = player.iceCubeBagsPurchased - day.bagsOfIceUsed;
            iceCubesOnHand = (iceCubesBeginningInventory + player.iceCubesPurchased) - day.iceCubesUsed;
        }
        public void LemonsOnHand(int lemonsUsed)
        {
            lemonsOnHand = (lemonsBeginningInventory + player.lemonsPurchased) - day.lemonsUsed;
        }
        public void SugarOnHand(int sugarUsed)
        {
            sugarCubesOnHand = (sugarCubesBeginningInventory + player.sugarPurchased) - day.sugarUsed;
        }
        public void CupsOnHand(int cupsUsed)
        {
            cupsOnHand = (cupsBeginningInventory + player.cupsPurchased) - cupsUsed;
        }
    }

}

