﻿using System;
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
