using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energyPer100Ml = double.Parse(Console.ReadLine());
            double sugarPer100Ml = double.Parse(Console.ReadLine());

            Console.WriteLine($"{volume}ml {name}:");

            double energyForThisVolume = energyPer100Ml * (volume / 100.00);
            double sugarForThisVolume = sugarPer100Ml * (volume / 100);

            Console.WriteLine($"{energyForThisVolume}kcal, {sugarForThisVolume}g sugars");

        }
    }
}
