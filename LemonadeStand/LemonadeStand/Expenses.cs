using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Expenses
    {
        public double bagsOfIceDebit;
        public double lemonsDebit;
        public double sugarCubesDebit;
        public double cupsDebit;
        public double totalExpenses;
        Player player;
        Ice ice;
        Lemons lemons;
        Sugar sugar;
        Cup cup;

        public Expenses()
        {
            ice = new Ice();
            lemons = new Lemons();
            sugar = new Sugar();
            cup = new Cup();
        }

        public void IcePurchases(int iceCubeBagsPurchased)
        {
            bagsOfIceDebit = iceCubeBagsPurchased * ice.bagPrice;
        }
        public void LemonPurchases(int lemonsPurchased)
        {
            lemonsDebit = lemonsPurchased * lemons.price;
        }
        public void SugarPurchases(int sugarPurchased)
        {
            sugarCubesDebit = sugarPurchased * sugar.price;
        }
        public void CupsPurchases(int cupsPurchased)
        {
            cupsDebit = cupsPurchased * cup.price;
        }
        public void TotalExpenses()
        {
            totalExpenses = cupsDebit + sugarCubesDebit + lemonsDebit + bagsOfIceDebit;
        }
    }
}
