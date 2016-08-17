using System;
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

        public Customer()  
        {
            //constructor
        }

        public void TakeInDemand (GamePlay.Demand demand)
        {
            //demand object 
        }

        public void ActOnCashBox(GamePlay.CashBox cashBox)
        {
            //cashbox method 
            //cashbox.
        }

        public void ActOnRecipe (Tertiary_Classes.Recipe recipe)
        {
            //Recipe method //return recipe to inventory, lemonadestand
            Console.WriteLine("How many lemons in your lemonade? (Enter integer number of lemons)");
            Console.ReadLine();
            Console.WriteLine("How sweet of a lemonade? (Enter integer number of sugars)");
            Console.ReadLine();
            Console.WriteLine("How cool of a lemonade? (Enter integer number of ice cubes)");
        }

        

       


















        }

}