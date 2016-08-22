using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class LemonadeStandClass
    {

        Inventory inventory;
        Price price;
        Tertiary_Classes.Recipe recipe = new Tertiary_Classes.Recipe();

        public LemonadeStandClass () //constructor
        {
            this.inventory = new Inventory();
            this.price = new Price();
        }

        public void GetInventory()
        {
            //method for getting inventory
        }
       
    }
}
