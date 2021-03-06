﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        Weather weather;
        Player player;
        Recipe recipe;
        Inventory inventory;
        Cup cup;
        Ingredient ingredient;
        Expenses expenses;
        Sales sales;
        Pitcher pitcher;
        Day day;
        Customer customer;
        Cash cash;
        int oneWeek;
        string dayOfWeek;
        string restartOption;


        public Game()
        {
            player = new Player();
            weather = new Weather();
            inventory = new Inventory(player, day);
            pitcher = new Pitcher(player);
            day = new Day(player, weather, inventory, pitcher);
            cash = new Cash();
            oneWeek = 8;
        }


        //day counter
        public void GameCounter()

        {
            while (oneWeek > 0)
            {

                if (oneWeek > 1)
                {
                    oneWeek--;

                }
                if (oneWeek <= 1)
                {
                    GameEndDisplay();
                    
                }


                DaySet();

            }

        }

        //end of game/week results


        //game introduction/rules
        public void GameIntroduction()
        {
            Console.WriteLine("Welcome to the Lemonade Stand\n\nA simulation in entrepreneurship. Your goal is to make as much money as possible.\n\nYou have control over many aspects of your lemonade stand. This includes:\n\nPricing\nRecipes\nInventory Management\nAnd navigating various weather conditions\n\nDo your best to keep costs low and demand high, and you will maximize your profits!\n\n");
            Console.ReadLine();
            GameCounter();
        }



        //weather simulation//get weather

        //display day number// display weather (temperature and forecast)//

        void DaySet()
        {
            switch (oneWeek)
            {
                case 7:
                    dayOfWeek = "Day One";
                    break;
                case 6:
                    dayOfWeek = "Day Two";
                    break;
                case 5:
                    dayOfWeek = "Day Three";
                    break;
                case 4:
                    dayOfWeek = "Day Four";
                    break;
                case 3:
                    dayOfWeek = "Day Five";
                    break;
                case 2:
                    dayOfWeek = "Day Six";
                    break;
                case 1:
                    dayOfWeek = "Day Seven";
                    break;
                default:
                    GameIntroduction();
                    break;

            }
            DayStart();
        }
        public void DayStart()
        {
            Console.WriteLine("\n\n" + dayOfWeek + "\n\nThe Forecast calls for:\n" + "" + weather.forecastWeather + "\n\n");
            InventoryUpdate();
            PurchaseInventoryIntro();
        }
        public void BeginningInventoryUpdate()
        {
            Console.WriteLine("\n\nCups: " + inventory.cupsBeginningInventory + "\nIce: " + inventory.iceCubesBeginningInventory + "\nLemons: " + inventory.lemonsBeginningInventory + "\nSugar: " + inventory.sugarCubesBeginningInventory + "");
        }
        public void InventoryUpdate()
        {
            Console.WriteLine("\n\nCups: " + inventory.cupsOnHand + "\nIce: " + inventory.iceCubesOnHand + "\nLemons: " + inventory.lemonsOnHand + "\nSugar: " + inventory.sugarCubesOnHand + "");
        }
        //Inventory Purchases
        //Cups
        //lemons
        //sugar
        //Ice cubes
        public void PurchaseInventoryIntro()

        {
            if (dayOfWeek == "Day One")
            {
                player.cashBalance = 20;
                Console.WriteLine("\n\nPurchase all your inventory items:\n\nCups\nLemons\nSugar\nIce\n\nRemember to take weather into consideration.\n\nYour cash balance is:\n\n$" + player.cashBalance + "\n\n");
            }
            else
            {
                Console.WriteLine("Purchase all your inventory items:\n\nCups\nLemons\nSugar\nIce\n\nRemember to take weather into consideration.\n\nYour cash balance is:\n\n$" + player.cashBalance + "\n\n");
            }
            GetInventory();
            SetBeginningInventory();
        }
        public void GetInventory()
        {
            player.CupsPurchase();
            player.LemonsPurchase();
            player.SugarPurchase();
            player.IcePurchase();
            inventory.CupsBeginningInventory();
            inventory.LemonsBeginningInventory();
            inventory.SugarBeginningInventory();
            inventory.IceBeginningInventory();
            BeginningInventoryUpdate();
            NewCashBalanceUpdate();
        }
        public void SetBeginningInventory()
        {
            inventory.CupsBeginningInventory();
            inventory.IceBeginningInventory();
            inventory.LemonsBeginningInventory();
            inventory.SugarBeginningInventory();
            RecipeIntroduction();
        }

        public void NewCashBalanceUpdate()
        {
            player.GetCashBalanceInventoryPurchase();
            Console.WriteLine("\n\nYour cash balance is now:\n\n$" + player.cashBalance + "");
        }
        public void NewProfitLossUpdate()
        {
            player.GrossProfitOrLoss(day.cupsSold);
            Console.WriteLine("Your Gross Profit/Loss is now:\n\n" + player.grossProfitOrLoss + "");
        }
        public void NewCupsSoldUpdate()
        {
            Console.WriteLine("" + customer.saleGuage + " cups sold today");
        }



        //Recipe set
        //lemons
        //sugar
        //ice cubes
        public void RecipeIntroduction()
        {
            Console.WriteLine("\n\nSet your lemonade pitcher recipe by adding parts of the following:\n\nLemons\nSugar\nIce\n\n");
            player.GetRecipe();
            Price();
        }


        //Price set (in cents)
        public void Price()
        {
            player.PriceSet();
            DailyRun();
        }

        //sales simulation (customers buy lemonade based on weather and recipe)
        //display results (daily cups sold, new money available total)

        //
        public void DailyRun()
        {
            day.PotentialCustomersGeneration();
            day.PotentialCustomersListGeneration();
            GameCounter();
            
        }

        //update inventory
        //next day


        public void GameEndDisplay()
        {
            Console.WriteLine("Your ending Profits/Losses are:\n\n" + player.grossProfitOrLoss + "");
            Console.ReadLine();
            Console.WriteLine("Would you like to play again press 1");
            restartOption = Console.ReadLine();
            {
                switch (restartOption)
                {
                    case "1":
                        GameIntroduction();
                        break;
                    default:
                        break;

                }

            }

        }
    }
}

