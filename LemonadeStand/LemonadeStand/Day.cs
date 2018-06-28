﻿using System;
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
                bool canStillSell = CupSaleCheck();
                if(!canStillSell)
                {
                    NewCupsSoldUpdate();
                    NewProfitLossUpdate();
                    NewCashBalanceUpdate();
                    break;
                }
            }
            return customers;

        }
        public bool CupSaleCheck()
        {
            if (customer.saleGuage > 4.5)
            {
                cupsSold ++;
                bool hasCups = CupCheck();
                PitchersUsedCheck();
                bool hasLemons = LemonCheck();
                IceCheck();
                SugarCheck();
                return hasCups && hasLemons;
            }
            return true;
        }
       
        public bool CupCheck()
        {
            inventory.cupsOnHand --;
            return inventory.cupsOnHand > 0;
            
        }
        public void PitchersUsedCheck()
        {
             pitchersUsed = 1 + (cupsSold / pitcher.cupsPerPitcher);
        }
        public bool LemonCheck()
        {
            lemonsUsed = pitchersUsed * pitcher.lemonsPerPitcher;
            inventory.lemonsOnHand = inventory.lemonsOnHand - lemonsUsed;
            return inventory.lemonsOnHand > 0;

        }
        public bool IceCheck()
        {
            iceCubesUsed = pitchersUsed * pitcher.icePerPitcher;
            inventory.iceCubesOnHand = inventory.iceCubesOnHand - iceCubesUsed;
            return inventory.iceCubesOnHand > 0;
           
        }
        public bool SugarCheck()
        {
            sugarUsed = pitchersUsed * pitcher.sugarPerPitcher;
            inventory.sugarCubesOnHand = inventory.iceCubesOnHand - sugarUsed;
            return inventory.sugarCubesOnHand > 0;
         
        }
        public void NewCashBalanceUpdate()
        {
            player.GetCashBalance();
            Console.WriteLine("Your cash balance is now:\n\n$" + player.cashBalance + "");
        }
        public void NewProfitLossUpdate()
        {
            player.GrossProfitOrLoss();
            Console.WriteLine("Your Gross Profit/Loss is now:\n\n" + player.grossProfitOrLoss + "");
        }
        public void NewCupsSoldUpdate()
        {
            Console.WriteLine("" + customer.saleGuage + " cups sold today");
        }

    }
}
