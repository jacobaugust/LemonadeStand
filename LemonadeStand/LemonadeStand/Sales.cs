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
        Expenses expenses;
        Customer customer;
        Player player;
        Day day;


        public Sales()
        {
            
            
        }

        public void TotalRevenue(int cupsSold, double lemonadePrice)
        {
            try
            {
                totalRevenue = cupsSold * lemonadePrice;
            }
            catch
            {
                totalRevenue = 0.00;
            }

        }
    }
}
