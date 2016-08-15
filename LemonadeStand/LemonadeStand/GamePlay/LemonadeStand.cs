using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.GamePlay
{
    class LemonadeStand
    {
        int predictedWeather; //Member Variables

        public LemonadeStand() //constructor
        {
            Player player = new Player();
            Customer customer = new Customer();
            Inventory inventory = new Inventory();
            Store store = new Store();
            Weather weather = new Weather();
            Day day = new Day();
        }


        public int SetPrice()
        {
            Console.WriteLine("Enter an integer value cooresponding to today's selling price");
            setPrice = parse.Int32(Console.ReadLine()); //convert userInput string to integer
        }

        public void PredictWeather()
        {
            predictedWeather = Random.Next(1, 10)

            if (predictedWeather > 7)
            {
                Console.WriteLine("The predicted forcast for the next 7 days is sunny");
            }
            else
            {
                Console.WriteLine("The predicted forcast for the next 7 days is raining!");
            }
        }

        public void CalculateCustomer()
        {
            customer.CalculateWeatherChanceOfBuying(weather);
            customer.CalculatePriceChanceOfBuying(SetPrice);
        }

        //public void RunStand() //Method for running the stand
        //{
        //    Player. something 

        //}
    }
}
