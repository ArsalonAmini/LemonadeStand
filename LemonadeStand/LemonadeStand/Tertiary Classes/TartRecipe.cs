using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.Tertiary_Classes
{
    class TartRecipe : Recipe
    {





        public override MakeLemonade()
        {
           
            //tartRecipe = 1 lemon + 0 sugar + 1 ice;
            //associate a cashbox (cost)with this recipe;
            //associate inventory with recipe;
        }

        public override GetPrice()
        {
            price = (1 * lemon.GetPrice()) + (0 * sugar.GetPrice()) + (1 * ice.GetPrice());
        }
    }
}
