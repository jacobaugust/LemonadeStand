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
        Recipe recipe;
        Ingredient ingredient;
        Expenses expenses;
        Sales sales;
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
            expenses = new Expenses();
            sales = new Sales();
            ice = new Ice();
            cash = new Cash();
            
        }


        public void CupsPurchase()
        {
            Console.WriteLine("Cups cost $0.05.\n\nHow many cups would you like to buy?");
            cupsPurchased = Convert.ToInt32(Console.ReadLine());
            expenses.CupsPurchases(cupsPurchased);
        }
        public void LemonsPurchase()
        {
            Console.WriteLine("Lemons cost $0.25.\n\nHow many lemons would you like to buy?");
            lemonsPurchased = Convert.ToInt32(Console.ReadLine());
            expenses.LemonPurchases(lemonsPurchased);
        }
        public void SugarPurchase()
        {
            Console.WriteLine("Sugar cubes cost $0.15 a cube.\n\nHow many sugar cubes would you like to buy?");
            sugarPurchased = Convert.ToInt32(Console.ReadLine());
            expenses.SugarPurchases(sugarPurchased);
        }
        public void IcePurchase()
        {
            Console.WriteLine("Ice costs $3.00 a bag and each bag contains 150 cubes of ice.\n\nHow many bags of ice would you like to buy?");
            iceCubeBagsPurchased = Convert.ToInt32(Console.ReadLine());
            expenses.IcePurchases(iceCubeBagsPurchased);
            iceCubesPurchased = iceCubeBagsPurchased * ice.iceCubesInBag;
            
        }
        //Cash Balance
        public void GetCashBalance()
        {
            expenses.TotalExpenses();
            sales.TotalRevenue();
            try
            {
                cashBalance = (cash.balance - expenses.totalExpenses) + (sales.totalRevenue);
            }
            catch
            {
                cashBalance = cash.balance;
            }
        }

        //Recipe Set
        public void LemonParts()
        {
            Console.WriteLine("How many lemons would you like to use in your pitcher recipe?");
            lemonParts = Convert.ToInt32(Console.ReadLine());
        }
        public void SugarParts()
        {
            Console.WriteLine("How many sugar cubes would you like to use in your pitcher recipe?");
            sugarParts = Convert.ToInt32(Console.ReadLine());
        }
        public void IceParts()
        {
            Console.WriteLine("How many ice cubes would you like to use in your pitcher recipe?");
            iceParts = Convert.ToInt32(Console.ReadLine());
        }
        //Pricing Set
        public void PriceSet()
        {
            Console.WriteLine("How much would you like to charge for your lemonade (enter price as shown i.e. 0.30 for thirty cents)?");
            lemonadePrice = Convert.ToInt32(Console.ReadLine());
        }
        public void GrossProfitOrLoss()
        {
            grossProfitOrLoss = sales.totalRevenue - expenses.totalExpenses;
        }
        
    }
}
