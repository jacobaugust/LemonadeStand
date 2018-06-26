using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Sales
    {
        public double totalRevenue;
        Customer customer;
        Player player;

        public Sales(Player player)
        {
            this.player = player;
        }

        public void TotalRevenue()
        {
            totalRevenue = customer.sales * player.lemonadePrice;
        }
    }
}
