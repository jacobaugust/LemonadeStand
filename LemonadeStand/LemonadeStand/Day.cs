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
        public Customer customer;
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
            this.weather = weather;
            this.inventory = inventory;
            this.pitcher = pitcher;
            customer = new Customer(player, weather);

        }
        public void PotentialCustomersGeneration()
        {
            Random rnd = new Random();
            potentialCustomers = rnd.Next(80, 121);

        }

        public void PotentialCustomersListGeneration()
        {
            List<Customer> customers = new List<Customer>();
            for (int i = 0; i < potentialCustomers; i++)
            {
                customers.Add(new Customer(player, weather));
                customers[i].DemandImpactPrice(potentialCustomers);
                customers[i].DemandImpactTemp(potentialCustomers);
                customers[i].DemandImpactWeatherConditions(potentialCustomers);
                customers[i].DemandImpactIce(potentialCustomers);
                customers[i].DemandImpactLemons(potentialCustomers);
                customers[i].DemandImpactSugar(potentialCustomers);
            }

        }
       
        public void CupCheck()
        {
            cupsUsed = Convert.ToInt32(cupsSold);
            if (inventory.cupsOnHand <= Convert.ToInt32(cupsSold))
            {
                cupsUsed = inventory.cupsOnHand / pitcher.cupsPerPitcher;
                cupsSold = inventory.cupsOnHand;
            }
            else
            {
                cupsUsed = Convert.ToInt32(cupsSold);
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
