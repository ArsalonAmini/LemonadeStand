using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.GamePlay.Abstract_Classes
{
    public abstract class WeatherChanceOfBuying
    {
        int weather; //variables

        public WeatherChanceOfBuying(int weather) //constructor
        {
            this.weather = weather;
        }

        public int WeatherChanceOfBuying()
        {
            if (weather = 1) //weather score from weather class 
            {
                chanceWeather = Random.Next(1, 10);
            }
            else if (weather < 1) //weather score from weather class
            {
                chanceWeather = Random.Next(20, 100);
            }
        }
    }
}
