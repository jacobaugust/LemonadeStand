using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        string name;
        Ice ice;
        Cash cash;
        Inventory inventory;
        Ingredient ingredient;
        Expenses expenses;
        Sales sales;
        Recipe recipe;
        public int cupsPurchased;
        public int sugarPurchased;
        public int lemonsPurchased;
        public int iceCubeBagsPurchased;
        public int iceCubesPurchased;
        public double cashBalance;
        public int lemonParts;
        public int sugarParts;
        public int iceParts;
        public double lemonadePrice;
        public double grossProfitOrLoss;

        public Player()
        {
            
            
            ice = new Ice();
            cash = new Cash();
            recipe = new Recipe();
            expenses = new Expenses();
            sales = new Sales();
            
        }


        public void CupsPurchase()
        {
            Console.WriteLine("Cups cost $0.02.\n\nHow many cups would you like to buy?");
            try
            {
                cupsPurchased = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please enter a valid number entry.");
                CupsPurchase();
            }
            expenses.CupsPurchases(cupsPurchased);
        }
        public void LemonsPurchase()
        {
            Console.WriteLine("Lemons cost $0.10.\n\nHow many lemons would you like to buy?");
            try
            {
                lemonsPurchased = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please enter a valid number entry.");
                LemonsPurchase();
            }
            expenses.LemonPurchases(lemonsPurchased);
        }
        public void SugarPurchase()
        {
            Console.WriteLine("Sugar cubes cost $0.05 a cube.\n\nHow many sugar cubes would you like to buy?");
            try
            {
                sugarPurchased = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please enter a valid number entry.");
                SugarPurchase();
            }
            expenses.SugarPurchases(sugarPurchased);
        }
        public void IcePurchase()
        {
            Console.WriteLine("Ice costs $2.00 a bag and each bag contains 150 cubes of ice.\n\nHow many bags of ice would you like to buy?");
            try
            {
                iceCubeBagsPurchased = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please enter a valid number entry.");
                IcePurchase();
            }
            expenses.IcePurchases(iceCubeBagsPurchased);
            iceCubesPurchased = iceCubeBagsPurchased * ice.iceCubesInBag;
            
        }
        //Cash Balance
        public void GetCashBalanceInventoryPurchase()
        {
            try
            {
                expenses.TotalExpenses();
                cashBalance = cashBalance - expenses.totalExpenses;
            }
            catch
            {
                cashBalance = cash.balance;
            }
           
        }
        public void GetBeginningCashBalance(int cupsSold)
        {
            expenses.TotalExpenses();
            sales.TotalRevenue(cupsSold, lemonadePrice);
            try
            {
                {
                    cashBalance = cashBalance  + (sales.totalRevenue);
                }
            }
            catch
            {
                cashBalance = cash.balance;
            }
        }

        public void GetCashBalance(int cupsSold)
        {
            expenses.TotalExpenses();
            sales.TotalRevenue(cupsSold, lemonadePrice);
            try
            {
                if (grossProfitOrLoss > 0)
                {
                    cashBalance = (cashBalance) + (grossProfitOrLoss);
                }
                
                
            }
            catch
            {
                cashBalance = cash.balance;
            }
        }

        //Recipe Set
        public void GetRecipe()
        {
            LemonParts();
            SugarParts();
            IceParts();
        }
        public void LemonParts()
        {
            Console.WriteLine("How many lemons would you like to use in your pitcher recipe?");
            try
            {
                lemonParts = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please enter a valid number entry.");
                LemonParts();
            }
        }
        public void SugarParts()
        {
            Console.WriteLine("How many sugar cubes would you like to use in your pitcher recipe?");
            try
            {
                sugarParts = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please enter a valid number entry.");
                SugarParts();
            }
        }
        public void IceParts()
        {
            Console.WriteLine("How many ice cubes would you like to use in your pitcher recipe?");
            try
            {
                iceParts = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please enter a valid number entry.");
                IceParts();
            }
        }
        //Pricing Set
        public void PriceSet()
        {
            Console.WriteLine("How much would you like to charge for your lemonade (enter price as shown i.e. 0.30 for thirty cents)?");
            try
            {
                lemonadePrice = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please enter a valid number entry.");
                PriceSet();
            }
        }
        public void GrossProfitOrLoss(int cupsSold)
        {
            sales.TotalRevenue(cupsSold, lemonadePrice);
            expenses.TotalExpenses();
            grossProfitOrLoss = sales.totalRevenue - expenses.totalExpenses;
        }
        
    }
}
