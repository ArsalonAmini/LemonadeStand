using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.Tertiary_Classes
{
    public class Ice
    {
        double ice;
        public Ice() //constructor
        {
            ice = 0.95;
        }

        public double GetPrice() 
        {
            return ice;
        }
    }
}
