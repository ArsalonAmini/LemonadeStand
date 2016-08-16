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
       
        public void TakeInInventory (Inventory inventory)
        {
            //inventory object
        }

        public void TakeInCustomer (Customer customer)
        {
            //customer object
        }

        public void TakeInLemonadeStand(LemonadeStand lemonadestand)
        {
            //LemonadeStand object
        }

        public void TakeInDemand(Demand demand)
        {
            //Demand method
        }

        public void TakeInWeather(Weather weather)
        {
            //weather object
        }
}
        

    