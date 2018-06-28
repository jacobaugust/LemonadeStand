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
        double saleGauge;


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
                saleGuage = (saleGuage + 2);
            }
            else if (player.lemonadePrice <= 0.20)
            {
                saleGuage = (saleGuage + 1.5);
            }
            else if (player.lemonadePrice <= 0.30)
            {
                saleGuage = (saleGuage + 1);
            }
            else if (player.lemonadePrice <= 0.40)
            {
                saleGuage = (saleGuage + 0.5);
            }
        }
        public void DemandImpactTemp()
        {
            if (weather.actualTemperature >= 85)
            {
                saleGuage = (saleGuage + 1.5);
            }
            else if (weather.actualTemperature >= 75)
            {
                saleGuage = (saleGuage + 1);
            }
            else if (weather.actualTemperature >= 65)
            {
                saleGuage = (saleGuage + 0.5);
            }
        }
        public void DemandImpactWeatherConditions()
        {
            switch (weather.actualCondition)
            {
                case "hot":
                    saleGuage = (saleGuage + 1);
                    break;
                case "hazy":
                    saleGuage = (saleGuage + 1);
                    break;
                case "muggy":
                    saleGuage = (saleGuage + 1);
                    break;
                default:
                    break;
            }

        }
        public void DemandImpactIce()
        {
            if (player.iceParts >= 6)
            {
                saleGuage = (saleGuage + 1);
            }
            else if (player.iceParts >= 4)
            {
                saleGuage = (saleGuage + 1.5);
            }
            else if (player.iceParts >= 2)
            {
                saleGuage = (saleGuage + 1);
            }
        }
        public void DemandImpactSugar()
        {
                if (player.sugarParts >= 8)
                {
                    saleGuage = (saleGuage + 0.5);
                }
                else if (player.sugarParts >= 6)
                {
                    saleGuage = (saleGuage + 1);
                }
                else if (player.sugarParts >= 4)
                {
                    saleGuage = (saleGuage + 1.5);
                }
                else if (player.sugarParts >= 2)
                {
                    saleGuage = (saleGuage + 1.5);
                }
         
        }
        public void DemandImpactLemons()
        {
            if (player.lemonParts >= 8)
            {
                saleGuage = (saleGuage + 0.5);
            }
            else if (player.lemonParts >= 6)
            {
                saleGuage = (saleGuage + 1.5);
            }
            else if (player.lemonParts >= 4)
            {
                saleGuage = (saleGuage + 1);
            }
            else if (player.lemonParts >= 2)
            {
                saleGuage = (saleGuage + 0.5);
            }
        }
           
        
    }
}
