using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        //private int actualWeather;
        //private int predictedWeather;
        private int weather;
        Random random = new Random();

        public Weather() //Constructor 
        {
            //constructor
        }
        public int ActualWeather() //Tested and verified by A Amini-Hajibashi on 8/19/2016
        {
            int actualWeather = random.Next(1, 100);

            if (actualWeather > 50)
            {
                weather = 1;
                Console.WriteLine("The Actual Weather for today is:");
                Console.WriteLine("It's sunny");
                return weather;
            }
            else if (actualWeather < 50)
            {
                weather = 0;
                Console.WriteLine("The Actual Weather for today is:");
                Console.WriteLine("It's raining");
                return weather;
            }
            else
            {
                weather = 2;
                Console.WriteLine("The weather is partly sunny today");
                Console.WriteLine("The Actual Weather for today is:");
                return weather;
            }
        }
        public void PredictWeather() //tested and verified by A Amini-Hajibashi on 8/17/2016
        {
            Random random = new Random();
            int predictedWeather = random.Next(1, 100);

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














