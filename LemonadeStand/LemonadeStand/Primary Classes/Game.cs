using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        Player player = new Player();
        Day day = new Day();
        Store store = new Store();
        int dayCounter;
        private int numberOfDays;
        private int i;

        public void NewGame()
        {
            Console.WriteLine("Welcome to A.Amini-Hajibashi's Lemonade Stand game");
            Console.WriteLine("The Rules are pretty Basic, for your convienience, Player");
            Console.WriteLine("Purchase Inventory from the Store");
            Console.WriteLine("SellLemonade to customer");
            Console.WriteLine("Rain or Shine try making your dime!");
            Console.ReadLine();
            numberOfDays = 0;
        }
        public void RunGame()
        {

            while (i < 7) //game loop
            {
                day = new Day();
                day.RunDay();
                i++;
            }
        }

    }
}














    


