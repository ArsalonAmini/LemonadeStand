using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Demand
    {
        public Demand()
        {
            //constructor
        }

        public void TakeInPrice(Price price)
        {
            //price object
        }

        public void TakeInWeather(Weather weather)
        {
            //weather object
        }

        public void CalculateBuyerChance (Customer customer)
        {
            //customer method
        }



        //    public int CalculatePriceChanceOfBuying() //Method
        //    {
        //        if (setPrice > 5) //price score from lemonadeStand class player input
        //        {
        //            priceDemand = Random.Next(1, 10);
        //        }
        //        else if (setPrice < 3)
        //        {
        //            priceDemand = Random.Next(50, 100);
        //        }
        //    }

        //    public int CalculateWeatherChanceOfBuying(Weather weather)
        //    {
        //        if (weather = 1) //weather score from weather class associated with Sunshine
        //        {
        //            chanceWeather = Random.Next(1, 10);
        //        }
        //        else if (weather = 0) //weather score from weather class associated with rain
        //        {
        //            chanceWeather = Random.Next(20, 100);
        //        }
        //        else
        //        {
        //            chanceWeather = Random.Next(1, 10);
        //        }
        //    }

        //    public int CalculateTotalCustomerChanceOfBuying(int chanceWeather, int priceDemand)
        //    {
        //        totalCustomerChance = chanceWeather + priceDemand;
        //    }

        //    public int CalculateSales() //Method requires instantiation and passing in of the customerfleet class 
        //    {
        //        if (totalCustomerChance > 20)
        //        {
        //            sales = < adult Customer > *totalCustomerChanceOfBuying + < child customer > *totalCustomerChanceOfBuying; //a list of customer objects each mulitplied by chance of buying mulitplier //don't need to store customer states

        //        }
        //        else
        //        {
        //            sales = < adult Customer > *totalCustomerChanceOfBuying + < child customer > *totalCustomerChanceOfBuying; //a list of customer objects each mulitplied by chance of buying mulitplier //don't need to store customer states
        //            inventory = sales - supplies //turn sales list into an integer number and multiply by recipe to get #lemons, #ice, # sugar 
        //            player.profit = sales xyz;
        //            Console.WriteLine("Total sales today {0}, inventory available Lemons {1}, sugar {2}, ice {3}, profts {4}", sales, Inventory.GetLemons, Inventory.GetSugar, Inventory.GetIce, profits);
        //        }

        //        public void CalculateCustomerChanceOfBuying()
        //    {
        //        customer.CalculatePriceChanceOfBuying(setPrice);
        //        customer.CalculateWeatherChanceOfBuying(weather);
        //        customer.CalculateTotalCustomerChanceOfBuying();
        //        customer.CalculateSales(customerFleet); //pass in customerfleet to sales score matrix and return profit
        //    }
        //}
        //}

    }
}
