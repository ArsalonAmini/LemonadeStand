using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class LemonadeStand
    {
        int predictedWeather; //Member Variables
        int setPrice;

        public LemonadeStand() //constructor
        {
            CashBox cashbox = new CashBox();
            Inventory inventory = new Inventory();
        }

        public void TakeInCustomer (Customer customer) //method for taking in the customer object
        {

        }
        
        public void TakeInPlayer (Player player) //method for taking in player object
        {

        }

        public void TakeInWeather (Weather weather) //method for taking in the weather object
        {

        }
       
        public void TakeInRecipe(Tertiary_Classes.Recipe recipe)
        {
            //Recipe Object
        }
    }
}
