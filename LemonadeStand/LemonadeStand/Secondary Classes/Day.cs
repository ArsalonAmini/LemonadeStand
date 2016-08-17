using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        Weather weather;
        Customer customer;

        public Day(Weather weather, Customer customer) //constructor
        {
            this.weather = weather;
            this.customer = customer;
        }

        public void TakeInInventory(Inventory inventory)
        {
            //inventory object
            Console.WriteLine("You have {0} lemons, {1} Sugars, {2} ice remaining", inventory.TakeInLemon, inventory.TakeInSugar, inventory.TakeInIce);
        }

        public void TakeInCustomer(Customer customer)
        {
            //customer object
        }

        public void TakeInLemonadeStand(LemonadeStand lemonadestand)
        {
            //LemonadeStand object
        }

        public void TakeInDemand(GamePlay.Demand demand)
        {
            //Demand method
        }

        public void TakeInWeather(Weather weather)
        {
            //weather object
        }

        private void TakeInGame (Game game) //pass in the game class 
        {
            //call the day method in game
            //game.day
        }
    }

}
        

    