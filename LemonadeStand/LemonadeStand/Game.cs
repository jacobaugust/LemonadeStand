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
        int oneWeek;
        string gameEnd;
        string dayOfWeek;


        public Game()
        {
            player = new Player();
            weather = new Weather();
            inventory = new Inventory(player);
            sales = new Sales(player);
            expenses = new Expenses(player);
            pitcher = new Pitcher(player);
            day = new Day(player);
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





                DayStart();

            }

        }

        //end of game/week results


        //game introduction/rules
        public void GameIntroduction()
        {
            Console.WriteLine("Welcome to the Lemonade Stand\n\nA simulation in entrepreneurship. Your goal is to make as much money as possible.\n\nYou have control over all aspects of your lemonade stand. This includes:\n\nPricing\nRecipes\nInventory Management\nPurchasing Supplies\nAnd navigating various weather conditions\n\nPut together the right mix of these factors on the right days and you will maximize your profits!");

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
        }
        public void DayStart()
        {
            Console.WriteLine("" + dayOfWeek + "\n\n The Forecast calls for:\n" + "" + weather.forecastWeather + "");
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
        public void GetCups()
        {
            player.CupsPurchase();
        }
        public void GetLemons()
        {
            player.LemonsPurchase();
        }
        public void GetSugar()
        {
            player.SugarPurchase();
        }
        public void GetIce()
        {
            player.IcePurchase();
        }
        //Cash Balance Update
        public void NewCashBalanceUpdate()
        {
            Console.WriteLine("Your cash balance is now:\n\n" + player.cashBalance + "");
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
        public void DailyResult()
        {
            
        }

        //update inventory
        //next day


        public void GameEndDisplay()
        {

        }



    }
}
