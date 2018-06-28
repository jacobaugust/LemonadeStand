using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        public double saleGuage;
        Player player;
        Weather weather;
        int percentChanceToBuy;
        int saleGauge;


        public Customer(Player player, Weather weather)
        {
            this.player = player;
            this.weather = weather;
            Random rnd = new Random();
            saleGuage = rnd.Next(0, 2);
        }

        public void DetermineIfPurchaseOccurs()
        {

        }

        public void DemandImpactPrice()
        {
            if (player.lemonadePrice <= 0.10)
            {
                percentChanceToBuy += 25;
                saleGuage = Convert.ToInt32(saleGuage + 2);
            }
            else if (player.lemonadePrice <= 0.20)
            {
                saleGuage = Convert.ToInt32(saleGuage + 1.5);
            }
            else if (player.lemonadePrice <= 0.30)
            {
                saleGuage = Convert.ToInt32(saleGuage + 1);
            }
            else if (player.lemonadePrice <= 0.40)
            {
                saleGuage = Convert.ToInt32(saleGuage + 0.5);
            }
        }
        public void DemandImpactTemp()
        {
            if (weather.actualTemperature >= 85)
            {
                saleGuage = Convert.ToInt32(saleGuage + 1.5);
            }
            else if (player.lemonadePrice >= 75)
            {
                saleGuage = Convert.ToInt32(saleGuage + 1);
            }
            else if (player.lemonadePrice >= 65)
            {
                saleGuage = Convert.ToInt32(saleGuage + 0.5));
            }
        }
        public void DemandImpactWeatherConditions()
        {
            switch (weather.actualCondition)
            {
                case "hot":
                    saleGuage = Convert.ToInt32(saleGuage + 1);
                    break;
                case "hazy":
                    saleGuage = Convert.ToInt32(saleGuage + 1);
                    break;
                case "muggy":
                    saleGuage = Convert.ToInt32(saleGuage + 1);
                    break;
                default:
                    break;
            }

        }
        public void DemandImpactIce()
        {
            if (player.iceParts >= 6)
            {
                saleGuage = Convert.ToInt32(saleGuage + 1);
            }
            else if (player.lemonadePrice >= 4)
            {
                saleGuage = Convert.ToInt32(saleGuage + 1.5);
            }
            else if (player.lemonadePrice >= 2)
            {
                saleGuage = Convert.ToInt32(saleGuage + 1);
            }
        }
        public void DemandImpactSugar()
        {
                if (player.iceParts >= 8)
                {
                    saleGuage = Convert.ToInt32(saleGuage + 0.5);
                }
                else if (player.lemonadePrice >= 6)
                {
                    saleGuage = Convert.ToInt32(saleGuage + 1);
                }
                else if (player.lemonadePrice >= 4)
                {
                    saleGuage = Convert.ToInt32(saleGuage + 1.5);
                }
                else if (player.lemonadePrice >= 2)
                {
                    saleGuage = Convert.ToInt32(saleGuage + 1.5);
                }
         
        }
        public void DemandImpactLemons(double potentialCustomers)
        {
            if (player.iceParts >= 8)
            {
                saleGuage = Convert.ToInt32(saleGuage + 0.5);
            }
            else if (player.lemonadePrice >= 6)
            {
                saleGuage = Convert.ToInt32(saleGuage + 1.5);
            }
            else if (player.lemonadePrice >= 4)
            {
                saleGuage = Convert.ToInt32(saleGuage + 1);
            }
            else if (player.lemonadePrice >= 2)
            {
                saleGuage = Convert.ToInt32(saleGuage + 0.5);
            }
        }
           
        
    }
}
