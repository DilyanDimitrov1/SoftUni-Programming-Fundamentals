using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundingAwayFromZero
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbersArray = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            for (int x = 0; x < numbersArray.Length; x++)
            {
                Console.WriteLine($"{numbersArray[x]} => {Math.Round(numbersArray[x], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
