using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.Tertiary_Classes
{
    public class Recipe
    {

        Random random;
        int customerPreference;

        public Recipe() //Constructor
        {
            this.random = new Random();
        }



        public virtual void MakeLemonade()
        {
            //lemonade recipe
            //associate make lemonade with cashbox
            //associate make lemonade with inventory
            //associate make lemonade with customer
        }
       
        //public virtual GetPrice()
        //{
        //    //price = (1 * lemon.GetPrice()) + (0 * sugar.GetPrice()) + (1 * ice.GetPrice());
        //}



       

    }
  
}
