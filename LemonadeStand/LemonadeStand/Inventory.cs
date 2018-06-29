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
                iceCubesBeginningInventory = (player.iceCubesPurchased + iceCubesOnHand);
                    
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
                sugarCubesBeginningInventory = (player.sugarPurchased + sugarCubesOnHand);
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
                lemonsBeginningInventory = (player.lemonsPurchased + lemonsOnHand);
            }
            catch
            {
                lemonsBeginningInventory = player.lemonsPurchased;
            }
           
        }
        public void CupsBeginningInventory()
        {
            if (player.cupsPurchased > 0)
            {
                try
                {
                    cupsBeginningInventory = (player.cupsPurchased + cupsOnHand);
                }
                catch
                {
                    cupsBeginningInventory = player.cupsPurchased;
                }
            }
        }
        public void IceOnHand(int iceCubesUsed)
        {
            iceCubesOnHand = (iceCubesBeginningInventory) - iceCubesUsed;
        }
        public void LemonsOnHand(int lemonsUsed)
        {
            if (lemonsBeginningInventory < lemonsUsed)
            {
                lemonsOnHand = lemonsBeginningInventory;
            }
            else
            {
                lemonsOnHand = (lemonsBeginningInventory) - lemonsUsed;
            }
        }
        public void SugarOnHand(int sugarUsed)
        {
            if (sugarCubesBeginningInventory < sugarUsed)
            {
                sugarCubesOnHand = 0;
            }
            else
            {
                sugarCubesOnHand = (sugarCubesBeginningInventory) - sugarUsed;
            }
        }
        public void CupsOnHand(int cupsUsed)
        {

            cupsOnHand = (cupsBeginningInventory) - cupsUsed;
        }
    }

}

