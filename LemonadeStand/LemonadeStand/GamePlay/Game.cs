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
        Weather weather = new Weather();
        Customer customer = new Customer();
        Day day = new Day();
        Store store = new Store();

        public void NewGame()
        {
            Console.WriteLine("Welcome to our game");
            SetNumberOfDays();
            Console.ReadLine();
        }
        public void RunGame()
        {
            //player.method
            //weather.method
            //customer.method
            //day.method
            //store.method
        }

        private void SetNumberOfDays()
        {
            Console.WriteLine("how many days?");
            Console.ReadLine();
        }
   
    }
}














    //public void Game() //constructor
    //{
    //    this.playerOne = new Player();
    //    this.playerTwo = new Player();
    //    this.numberOfDays = 7;
    //    this.day = 0;
    //}

    //public void RunGame()
    //{
    //    Console.WriteLine("Welcome to my LemonadeStand Game");
    //    while (this.day <this.numberOfDays) //Gaming Loop
    //    {

    //        Console.WriteLine("Welcome to day {0}", this.day);
    //        LemonadeStand lemonadeStand = new LemonadeStand();
    //        lemonadeStand.RunStand();
    //        this.day++;
    //    }
    //}

}
