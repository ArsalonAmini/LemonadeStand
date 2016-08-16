using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.GamePlay
{
    class Price
    {
        public void SetPrice() //Method for setting the price of the day
        {
            Console.WriteLine("Enter an integer value cooresponding to today's selling price");
            setPrice = parse.Int32(Console.ReadLine()); //convert userInput string to integer
        }


    }
}
