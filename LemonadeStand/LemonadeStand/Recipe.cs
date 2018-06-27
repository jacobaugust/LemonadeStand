using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {
        Player player;
        public Recipe(Player player)
        {
            this.player = player;
        }

        public void GetRecipe()
        {
            player.LemonParts();
            player.SugarParts();
            player.IceParts();
        }
    }
}
