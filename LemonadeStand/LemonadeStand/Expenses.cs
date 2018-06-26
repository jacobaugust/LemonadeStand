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

        public Expenses(Player player)
        {
            this.player = player;
            ice = new Ice();
            lemons = new Lemons();
            sugar = new Sugar();
            cup = new Cup();
        }

        public void IceDebit()
        {
            bagsOfIceDebit = player.iceCubeBagsPurchased * ice.bagPrice;
        }
        public void LemonPurchases()
        {
            lemonsDebit = player.lemonsPurchased * lemons.price;
        }
        public void SugarPurchases()
        {
            sugarCubesDebit = player.sugarPurchased * sugar.price;
        }
        public void cupsPurchased()
        {
            cupsDebit = player.cupsPurchased * cup.price;
        }
        public void TotalExpenses()
        {
            totalExpenses = cupsDebit + sugarCubesDebit + lemonsDebit + bagsOfIceDebit;
        }
    }
}
