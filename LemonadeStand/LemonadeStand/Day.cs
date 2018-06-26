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
        public double potentialCustomers;
        public double actualCustomers;

        public Day(Player player, Weather weather)
        {
            this.player = player;
            PotentialCustomersGeneration();
            this.weather = weather;
            
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
                actualCustomers = Convert.ToInt32(actualCustomers + (potentialCustomers * 0.20));
            }
            else if (player.lemonadePrice <= 0.20)
            {
                actualCustomers = Convert.ToInt32(actualCustomers + (potentialCustomers * 0.15));
            }
            else if (player.lemonadePrice <= 0.30)
            {
                actualCustomers = Convert.ToInt32(actualCustomers + (potentialCustomers * 0.10));
            }
            else if (player.lemonadePrice <= 0.40)
            {
                actualCustomers = Convert.ToInt32(actualCustomers + (potentialCustomers * 0.05));
            }
        }
        public void DemandImpactTemp()
        {
            if (weather.actualTemperature >= 85)
            {
                actualCustomers = Convert.ToInt32(actualCustomers + (potentialCustomers * 0.15));
            }
            else if (player.lemonadePrice >= 75)
            {
                actualCustomers = Convert.ToInt32(actualCustomers + (potentialCustomers * 0.10));
            }
            else if (player.lemonadePrice >= 65)
            {
                actualCustomers = Convert.ToInt32(actualCustomers + (potentialCustomers * 0.05));
            }
        }
        public void DemandImpactWeatherConditions()
        {
            switch (weather.actualCondition)
            {
                case "hot":
                    actualCustomers = Convert.ToInt32(actualCustomers + (potentialCustomers * 0.10)); 
                    break;
                case "hazy":
                    actualCustomers = Convert.ToInt32(actualCustomers + (potentialCustomers * 0.10));
                    break;
                case "muggy":
                    actualCustomers = Convert.ToInt32(actualCustomers + (potentialCustomers * 0.10));
                    break;
                default:
                    break;

            }
        }

    }
}
