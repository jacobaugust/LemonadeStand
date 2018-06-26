using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        Player player;
        Weather weather;
        Inventory inventory;
        Pitcher pitcher;
        public double potentialCustomers;
        public double cupsSold;
        public int bagsOfIceUsed;
        public int iceCubesUsed;
        public int lemonsUsed;
        public int sugarUsed;
        public int cupsUsed;
        public int pitchersUsed;

        public Day(Player player, Weather weather, Inventory inventory, Pitcher pitcher)
        {
            this.player = player;
            PotentialCustomersGeneration();
            this.weather = weather;
            this.inventory = inventory;
            pitcher = new Pitcher(player);
            
        }

        public void PotentialCustomersGeneration()
        {
            Random rnd = new Random();
            potentialCustomers = rnd.Next(80, 121);

        }
        public void DemandImpactPrice()
        {
            if (player.lemonadePrice <= 0.10)
            {
                cupsSold = Convert.ToInt32(cupsSold + (potentialCustomers * 0.20));
            }
            else if (player.lemonadePrice <= 0.20)
            {
                cupsSold = Convert.ToInt32(cupsSold + (potentialCustomers * 0.15));
            }
            else if (player.lemonadePrice <= 0.30)
            {
                cupsSold = Convert.ToInt32(cupsSold + (potentialCustomers * 0.10));
            }
            else if (player.lemonadePrice <= 0.40)
            {
                cupsSold = Convert.ToInt32(cupsSold + (potentialCustomers * 0.05));
            }
        }
        public void DemandImpactTemp()
        {
            if (weather.actualTemperature >= 85)
            {
                cupsSold = Convert.ToInt32(cupsSold + (potentialCustomers * 0.15));
            }
            else if (player.lemonadePrice >= 75)
            {
                cupsSold = Convert.ToInt32(cupsSold + (potentialCustomers * 0.10));
            }
            else if (player.lemonadePrice >= 65)
            {
                cupsSold = Convert.ToInt32(cupsSold + (potentialCustomers * 0.05));
            }
        }
        public void DemandImpactWeatherConditions()
        {
            switch (weather.actualCondition)
            {
                case "hot":
                    cupsSold = Convert.ToInt32(cupsSold + (potentialCustomers * 0.10)); 
                    break;
                case "hazy":
                    cupsSold = Convert.ToInt32(cupsSold + (potentialCustomers * 0.10));
                    break;
                case "muggy":
                    cupsSold = Convert.ToInt32(cupsSold + (potentialCustomers * 0.10));
                    break;
                default:
                    break;
            }

        }
        public void DemandImpactIce()
        {
            if (player.iceParts >= 6)
            {
                cupsSold = Convert.ToInt32(cupsSold + (potentialCustomers * 0.10));
            }
            else if (player.lemonadePrice >= 4)
            {
                cupsSold = Convert.ToInt32(cupsSold + (potentialCustomers * 0.15));
            }
            else if (player.lemonadePrice >= 2)
            {
                cupsSold = Convert.ToInt32(cupsSold + (potentialCustomers * 0.10));
            }
        }
        public void DemandImpactSugar()
        {
            if (player.iceParts >= 8)
            {
                cupsSold = Convert.ToInt32(cupsSold + (potentialCustomers * 0.05));
            }
            else if (player.lemonadePrice >= 6)
            {
                cupsSold = Convert.ToInt32(cupsSold + (potentialCustomers * 0.10));
            }
            else if (player.lemonadePrice >= 4)
            {
                cupsSold = Convert.ToInt32(cupsSold + (potentialCustomers * 0.15));
            }
            else if (player.lemonadePrice >= 2)
            {
                cupsSold = Convert.ToInt32(cupsSold + (potentialCustomers * 0.05));
            }
        }
        public void DemandImpactLemons()
        {
            if (player.iceParts >= 8)
            {
                cupsSold = Convert.ToInt32(cupsSold + (potentialCustomers * 0.05));
            }
            else if (player.lemonadePrice >= 6)
            {
                cupsSold = Convert.ToInt32(cupsSold + (potentialCustomers * 0.15));
            }
            else if (player.lemonadePrice >= 4)
            {
                cupsSold = Convert.ToInt32(cupsSold + (potentialCustomers * 0.10));
            }
            else if (player.lemonadePrice >= 2)
            {
                cupsSold = Convert.ToInt32(cupsSold + (potentialCustomers * 0.05));
            }
        }
        public void CupCheck()
        {
            cupsUsed = Convert.ToInt32(cupsSold);
            if (inventory.cupsOnHand <= Convert.ToInt32(cupsSold))
            {
                cupsSold = inventory.cupsOnHand;
            }
        }
        public void PitcherCheck()
        {
            pitchersUsed = Convert.ToInt32(cupsSold) / pitcher.cupsPerPitcher;
        }
        public void LemonCheck()
        {
            lemonsUsed = pitchersUsed * pitcher.lemonsPerPitcher;
            if(lemonsUsed > inventory.lemonsOnHand)
            {
                pitchersUsed = inventory.lemonsOnHand / pitcher.lemonsPerPitcher;
                cupsSold = (pitchersUsed * pitcher.cupsPerPitcher);
            }

        }
        public void IceCheck()
        {
            iceCubesUsed = pitchersUsed * pitcher.icePerPitcher;
            if (iceCubesUsed > inventory.iceCubesOnHand)
            {
                pitchersUsed = inventory.iceCubesOnHand / pitcher.icePerPitcher;
                cupsSold = (pitchersUsed * pitcher.cupsPerPitcher);
            }
        }
        public void SugarCheck()
        {
            sugarUsed = pitchersUsed * pitcher.sugarPerPitcher;
            if (sugarUsed > inventory.sugarCubesOnHand)
            {
                pitchersUsed = inventory.iceCubesOnHand / pitcher.icePerPitcher;
                cupsSold = (pitchersUsed * pitcher.cupsPerPitcher);
            }
        }
            
    }
}
