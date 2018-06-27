using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        public double cupsSold;
        Player player;
        Weather weather;
       

        public Customer(Player player, Weather weather)
        {
            this.player = player;
            this.weather = weather;
           
        }

        
        public void DemandImpactPrice(double potentialCustomers)
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
        public void DemandImpactTemp(double potentialCustomers)
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
        public void DemandImpactWeatherConditions(double potentialCustomers)
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
        public void DemandImpactIce(double potentialCustomers)
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
        public void DemandImpactSugar(double potentialCustomers)
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
        public void DemandImpactLemons(double potentialCustomers)
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
    }
}
