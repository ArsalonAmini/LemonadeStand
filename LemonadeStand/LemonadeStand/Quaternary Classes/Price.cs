using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Price
    {
        private object setPrice;

        public void SetPrice() //Method for setting the price of the day
        {
            Console.WriteLine("Enter an integer value cooresponding to today's selling price");
            setPrice = Convert.ToInt32(Console.ReadLine()); //convert userInput string to integer
        }
        

    }
}
