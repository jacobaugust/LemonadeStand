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
        public int bagsOfIceUsed;
        public int iceCubesUsed;
        public int lemonsUsed;
        public int sugarUsed;
        public int cupsUsed;
        public int pitchersUsed;
        public int cupsSold;

        public Day(Player player, Weather weather, Inventory inventory, Pitcher pitcher)
        {
            this.player = player;
            this.weather = weather;
            this.inventory = inventory;
            this.pitcher = pitcher;


        }
        public void PotentialCustomersGeneration()
        {
            Random rnd = new Random();
            potentialCustomers = rnd.Next(80, 121);

        }

        public List<Customer> PotentialCustomersListGeneration()
        {
            List<Customer> customers = new List<Customer>();
            for (int i = 0; i < potentialCustomers; i++)
            {
                customers.Add(new Customer(player, weather));
                customers[i].DemandImpactPrice();
                customers[i].DemandImpactTemp();
                customers[i].DemandImpactWeatherConditions();
                customers[i].DemandImpactIce();
                customers[i].DemandImpactLemons();
                customers[i].DemandImpactSugar();
                bool canStillSell = CupSaleCheck(customers[i]);
                if(!canStillSell)
                {
                    NewCupsSoldUpdate();
                    NewProfitLossUpdate();
                    NewCashBalanceUpdate();
                    break;
                }
            }
            NewCupsSoldUpdate();
            NewProfitLossUpdate();
            NewCashBalanceUpdate();
            return customers;

        }
        public bool CupSaleCheck(Customer customer)
        {
            if (customer.saleGuage > 4.5)
            {

                cupsSold ++;
                cupsUsed ++;
                bool hasCups = CupCheck();
                if(!hasCups)
                {
                    return false;
                }
                PitchersUsedCheck();
                bool hasLemons = LemonCheck();
                if(!hasLemons)
                {
                    return false;
                }
                bool hasIce = IceCheck();
                if (!hasIce)
                {
                    return false;
                }
                bool hasSugar = SugarCheck();
                if (!hasSugar)
                {
                    return false;
                }
                return hasCups && hasLemons && hasIce && hasSugar;
            }
            return true;
        }
       
        public bool CupCheck()
        {
            inventory.CupsOnHand(cupsUsed);
            return inventory.cupsOnHand > 0;
            
        }
        public void PitchersUsedCheck()
        {
             pitchersUsed = 1 + (cupsSold / pitcher.cupsPerPitcher);
        }
        public bool LemonCheck()
        {
            lemonsUsed = pitchersUsed * player.lemonParts;
            inventory.LemonsOnHand(lemonsUsed);
            if(lemonsUsed > inventory.lemonsOnHand)
            {
                cupsSold --;
                cupsUsed--;
                inventory.cupsOnHand++;
            }
            return inventory.lemonsOnHand > player.lemonParts;

        }
        public bool IceCheck()
        {
            iceCubesUsed = pitchersUsed * player.iceParts;
            inventory.IceOnHand(iceCubesUsed);
            if (iceCubesUsed > inventory.iceCubesOnHand)
            {
                cupsSold--;
                cupsUsed--;
                inventory.cupsOnHand++;
            }
            return inventory.iceCubesOnHand > player.iceParts;
           
        }
        public bool SugarCheck()
        {
            sugarUsed = pitchersUsed * player.sugarParts;
            inventory.SugarOnHand(sugarUsed);
            if (sugarUsed > inventory.sugarCubesOnHand)
            {
                cupsSold--;
                cupsUsed--;
                inventory.cupsOnHand++;
            }
            return inventory.sugarCubesOnHand > player.sugarParts;
         
        }
        public void NewCashBalanceUpdate()
        {
            player.GetCashBalance(cupsSold);
            Console.WriteLine("\n\nYour cash balance is now:\n\n$" + player.cashBalance + "");
        }
        public void NewProfitLossUpdate()
        {

            player.GrossProfitOrLoss(cupsSold);
            Console.WriteLine("\n\nYour Gross Profit/Loss is now:\n\n" + player.grossProfitOrLoss + "");
        }
        public void NewCupsSoldUpdate()
        {
            Console.WriteLine("\n\n" + cupsSold + " cups sold today");
        }

    }
}
