﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        //member variables - getTemp, rain, sunshine, actualWeather, predictedWeather
        //member methods - GetTemp(), GetRain(), GetSunshine(), ActualWeather(), PredictedWeather() //Data sent back to customer class for logic processing

        int getTemp;
        string rain;
        string sunshine;

    }
    public int GetTemp()
    {
        getTemp = Random.Next(50, 77);
        Console.WriteLine("The temperature is {0}", getTemp);
    }
    public int GetRain()
    {
        rain = Random.Next(1, 10)

        }
    public int GetSunshine()
    {
        sunshine = Random.Next(1, 10);

    }
    public int ActualWeather()
    {
        if (getTemp == 55 < x > 75 && rain == x < 7 && sunshine == x < 7)
        {
            weather = 1;
            Console.WriteLine("It's sunny");
        }
        else
        {
            weather = 0;
            Console.WriteLine("It's raining")
         }
    }
}
