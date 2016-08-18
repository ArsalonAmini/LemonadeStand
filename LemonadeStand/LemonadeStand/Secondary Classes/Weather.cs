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

        public Weather() //Constructor 
        {
            //constructor
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
    }

}














