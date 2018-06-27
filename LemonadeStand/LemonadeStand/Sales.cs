using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Sales
    {
        public double totalRevenue;
        public double grossProfitOrLoss;
        Expenses expenses;
        Customer customer;
        Player player;
        Day day;


        public Sales(Player player, Day day, Expenses expenses)
        {
            this.player = player;
            this.day = day;
            this.expenses = expenses;
            TotalRevenue();
        }

        public void TotalRevenue()
        {
            try
            {
                totalRevenue = day.cupsSold * player.lemonadePrice;
            }
            catch
            {
                totalRevenue = 0.00;
            }

        }
    }
}
