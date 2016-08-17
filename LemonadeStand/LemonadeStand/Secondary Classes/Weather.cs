using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        private int actualWeather;
        private int predictedWeather;
        private int weather;
        Random random = new Random();


        //member variables - getTemp, rain, sunshine, actualWeather, predictedWeather
        //member methods - GetTemp(), GetRain(), GetSunshine(), ActualWeather(), PredictedWeather() //Data sent back to customer class for logic processing


        public Weather() //Constructor 
        {
            //constructor
        }

        public void ActOnCustomer(Customer customer)
        {
            //customer method
        }

        public void ActOnDemand(Demand demand)
        {
            //demand method
        }

        public void ActOnDay(Day day)
        {
            //day method
        }

        public void PredictWeather()
        {
           predictedWeather = random.Next(1, 100);

            if (predictedWeather > 50)
            {
                Console.WriteLine("The predicted forcast for the next 7 days is sunny");

            }
            else
            {
                Console.WriteLine("The predicted forcast for the next 7 days is raining!");
            }
        }

        public void ActualWeather()
        {
            actualWeather = random.Next(1, 100);

            if (actualWeather > 50)
            {
                weather = 1;
                Console.WriteLine("It's sunny");
            }
            else if (actualWeather < 50)
            {
                weather = 0;
                Console.WriteLine("It's raining");
            }
        }

    }

}














