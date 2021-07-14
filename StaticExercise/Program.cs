using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var cTemp = TempConverter.FahrenheitToCelsius(68);
            var fTemp = TempConverter.CelsiusToFahrenheit(20);

            Console.WriteLine(cTemp);
            Console.WriteLine(fTemp);

            


        }
    }
}
