using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        private string name;
        private LemonadeStand lemonadeStand;

        //Member Variables

        public Player() //constructor
        {
            this.lemonadeStand = new LemonadeStand();
        }

        public string SetName() //Method for storing/getting name
        {
            Console.WriteLine("Enter your prefered name of choice:");
            name = Console.ReadLine();
        }
        public void RunStand()
        {
            lemonadeStand.SetPrice();
        }

    }
