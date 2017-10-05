using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConversion
{
    class Program
    {
        static double FahrenheitToCelsius(double Fahrenheit)
        {
            return (Fahrenheit - 32) * 5 / 9;

        }



        static void Main(string[] args)
        {
            var Fahrenheit = double.Parse(Console.ReadLine());
            var Celsius = FahrenheitToCelsius(Fahrenheit);

            Console.WriteLine($"{Celsius:f2}");

        }
    }
}
