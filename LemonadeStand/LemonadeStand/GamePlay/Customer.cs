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

        public Customer() //constructor 
        {
            this.weatherActual = Weather weather;
            this.price = LemonadeStand Setprice;
        }


        public int CalculatePriceChanceOfBuying() //Method
        {
            if (setPrice > 5) //price score from lemonadeStand class player input
            {
                priceDemand = Random.Next(1, 10);
            }
            else if (setPrice < 3)
            {
                priceDemand = Random.Next(50, 100);
            }
        }

        public int CalculateWeatherChanceOfBuying(Weather weather)
        {
            if (weather = 1) //weather score from weather class associated with Rain
            {
                chanceWeather = Random.Next(1, 10);
            }
            else if (weather < 1) //weather score from weather class associated with Sunshine
            {
                chanceWeather = Random.Next(20, 100);
            }
            else
            {
                chanceWeather = Random.Next(1, 10);
            }
        }


        public int CalculateTotalCustomerChanceOfBuying(int chanceWeather, int priceDemand)
        {
            totalCustomerChance = chanceWeather + priceDemand;
        }

        //public int BuyLemonade() //Pass in customerFleet member variable customer and
        //If criteria is met, make array of customers purchase or not purchase or whatever
        //{
        //    if (totalCustomerChance > 20)
        //    {
        //        Player.profit = +1 //add lemonade sale profit to variable profit (player class)
        //        inventory.Lemonade - 1 //reduce lemonade inventory by 1 (3 lemons, 2 sugars and 4 ices) in (inventory class)
        //}
        //}
    }
}

//member variables - numberofCups, ChangeOfBuying(PricePoint), 
//member methods - .BuyLemonade(int cups,) , ChanceOfBuyingPrice(), ChanceOfBuyingWeather()