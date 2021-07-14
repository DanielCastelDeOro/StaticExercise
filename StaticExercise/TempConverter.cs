using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    class TempConverter
    {
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            var fTemp = (fahrenheit - 32) / 1.8;
            //var ftemp = (fahrenheit - 32) * 9 / 5;
            return fTemp;
        }

        public static double CelsiusToFahrenheit(double celsius)
        {
           return (celsius * 9) / 5 + 32; 
        }

    }
}
