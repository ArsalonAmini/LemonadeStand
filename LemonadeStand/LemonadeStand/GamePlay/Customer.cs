﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{

    public class Customer
    {
        int weatherChance;
        int priceDemand;
        int price;

        public Customer() //constructor 
        {
           
        }

        public int ChooseLemonade()
        {
            Console.WriteLine("How many lemons in your lemonade? (Enter integer number of lemons)");
            Console.ReadLine();
            Console.WriteLine("How sweet of a lemonade? (Enter integer number of sugars)");
            Console.ReadLine();
            Console.WriteLine("How cool of a lemonade? (Enter integer number of ice cubes)");
        }

    }

}