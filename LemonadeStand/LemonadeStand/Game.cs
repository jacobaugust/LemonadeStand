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
        string restartOption;


        public Game()
        {
            player = new Player();
            weather = new Weather();
            inventory = new Inventory(player, day);
            sales = new Sales(player, day, expenses);
            expenses = new Expenses(player);
            pitcher = new Pitcher(player);
            customer = new Customer(player, weather);
            recipe = new Recipe(player);
            day = new Day(player, weather, inventory, pitcher, customer);
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
            Console.WriteLine("Welcome to the Lemonade Stand\n\nA simulation in entrepreneurship. Your goal is to make as much money as possible.\n\nYou have control over all aspects of your lemonade stand. This includes:\n\nPricing\nRecipes\nInventory Management\nPurchasing Supplies\nAnd navigating various weather conditions\n\nPut together the right mix of these factors on the right days and you will maximize your profits!\n\n");
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
            Console.WriteLine("" + dayOfWeek + "\n\nThe Forecast calls for:\n" + "" + weather.forecastWeather + "\n\n");
            PurchaseInventoryIntro();
        }
        //Inventory Purchases
        //Cups
        //lemons
        //sugar
        //Ice cubes
        public void PurchaseInventoryIntro()
        {
            player.GetCashBalance();
            Console.WriteLine("Purchase all your inventory items:\n\nCups\nLemons\nSugar\nIce\n\nRemember to take weather into consideration.\n\nYour cash balance is:\n\n" + player.cashBalance + "");
            GetInventory();
        }
        public void GetInventory()
        {
            player.CupsPurchase();
            NewCashBalanceUpdate();
            player.LemonsPurchase();
            NewCashBalanceUpdate();
            player.SugarPurchase();
            NewCashBalanceUpdate();
            player.IcePurchase();
            NewCashBalanceUpdate();
            RecipeIntroduction();
        }

        //Cash Balance Update
        public void NewCashBalanceUpdate()
        {
            Console.WriteLine("Your cash balance is now:\n\n" + player.cashBalance + "");
        }
        public void NewProfitLossUpdate()
        {
            player.GrossProfitOrLoss();
            Console.WriteLine("Your Gross Profit/Loss is now:\n\n" + sales.grossProfitOrLoss + "");
        }

        //Recipe set
        //lemons
        //sugar
        //ice cubes
        public void RecipeIntroduction()
        {
            Console.WriteLine("Set your lemonade pitcher recipe by adding parts of the following:\n\nLemons\nSugar\nIce\n\n");
            recipe.GetRecipe();
        }


        //Price set (in cents)
        public void Price()
        {
            player.PriceSet();
        }

        //sales simulation (customers buy lemonade based on weather and recipe)
        //display results (daily cups sold, new money available total)
        public void DailyRun()
        {
            customer.PotentialCustomersGeneration();
            customer.DemandImpactPrice();
            customer.DemandImpactTemp();
            customer.DemandImpactWeatherConditions();
            customer.DemandImpactIce();
            customer.DemandImpactSugar();
            customer.DemandImpactLemons();
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
            Console.WriteLine("Your ending Profits/Losses are:\n\n" + sales.grossProfitOrLoss + "");
            Console.ReadLine();
            Console.WriteLine("Would you like to play again press 1");
            restartOption = Console.ReadLine();
            void RestartEnd()
            {
                switch (restartOption)
                {
                    case "1":
                        new Game();
                        break;
                    default:
                        break;

                }

            }

        }
    }
}

