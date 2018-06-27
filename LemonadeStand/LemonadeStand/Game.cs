using System;
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
        int oneWeek;
        string dayOfWeek;


        public Game()
        {
            player = new Player();
            weather = new Weather();
            inventory = new Inventory(player, day);
            sales = new Sales(player, day, expenses);
            expenses = new Expenses(player);
            pitcher = new Pitcher(player);
            customer = new Customer();
            day = new Day(player, weather, inventory, pitcher, customer);
            oneWeek = 7;
        }


        //day counter
        public void GameCounter()

        {
            for (int i = 0; i < 0; i++)
            {

                if (oneWeek > 1)
                {
                    oneWeek--;

                }
                if (oneWeek < 1)
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
            Console.WriteLine("Welcome to the Lemonade Stand\n\nA simulation in entrepreneurship. Your goal is to make as much money as possible.\n\nYou have control over all aspects of your lemonade stand. This includes:\n\nPricing\nRecipes\nInventory Management\nPurchasing Supplies\nAnd navigating various weather conditions\n\nPut together the right mix of these factors on the right days and you will maximize your profits!");
            GameCounter();
        }



        //weather simulation//get weather
        
        //display day number// display weather (temperature and forecast)//

        void DaySet()
        {
            switch (oneWeek)
            {
                case 1:
                    dayOfWeek = "Day One";
                    break;
                case 2:
                    dayOfWeek = "Day Two";
                    break;
                case 3:
                    dayOfWeek = "Day Three";
                    break;
                case 4:
                    dayOfWeek = "Day Four";
                    break;
                case 5:
                    dayOfWeek = "Day Five";
                    break;
                case 6:
                    dayOfWeek = "Day Six";
                    break;
                case 7:
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
            Console.WriteLine("" + dayOfWeek + "\n\n The Forecast calls for:\n" + "" + weather.forecastWeather + "");
            PurchaseInventoryIntro();
        }
        //Inventory Purchases
        //Cups
        //lemons
        //sugar
        //Ice cubes
        public void PurchaseInventoryIntro()
        {
            Console.WriteLine("Purchase all your inventory items:\n\nCups\nLemons\nSugar\nIce\n\nRemember to take weather into consideration./n/nYour cash balance is:\n\n"+ player.cashBalance +"");
        }
        public void GetInventory()
        {
            player.CupsPurchase();
            player.LemonsPurchase();
            player.SugarPurchase();
            player.IcePurchase();
        }
        
        //Cash Balance Update
        public void NewCashBalanceUpdate()
        {
            Console.WriteLine("Your cash balance is now:\n\n" + player.cashBalance + "");
        }
        public void NewProfitLossUpdate()
        {
            player.GrossProfitOrLoss();
            Console.WriteLine("Your Gross Profit/Loss is now:\n\n"+ sales.grossProfitOrLoss + "");
        }
        //Recipe set
        //lemons
        //sugar
        //ice cubes
        public void LemonAdd()
        {
            player.LemonParts();
        }
        public void SugarAdd()
        {
            player.SugarParts();
        }
        public void IceAdd()
        {
            player.IceParts();
        }
        //Price set (in cents)
        public void Price()
        {
            player.PriceSet();
        }

        //sales simulation (customers buy lemonade based on weather and recipe)
        public void SalesSimulation()
        {
            
        }

        //display results (daily cups sold, new money available total)
        public void DailyRun()
        {
            day.PotentialCustomersGeneration();
            day.DemandImpactPrice();
            day.DemandImpactTemp();
            day.DemandImpactWeatherConditions();
            day.DemandImpactIce();
            day.DemandImpactSugar();
            day.DemandImpactLemons();
            day.CupCheck();
            day.PitcherCheck();
            day.LemonCheck();
            day.IceCheck();
            day.SugarCheck();
            NewProfitLossUpdate();
            NewCashBalanceUpdate();
            NewProfitLossUpdate();
        }

        //update inventory
        //next day


        public void GameEndDisplay()
        {
            Console.WriteLine("Your ending Profits/Losses are:\n\n"+ sales.grossProfitOrLoss + "");
        }



    }
}
