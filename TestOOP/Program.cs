
using System;

namespace TestOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var weatherClass = new Weather();

            var currentTemp = 81;

           var result =  weatherClass.WeatherScale(currentTemp);

            Console.WriteLine(result);
        }
    }
}
