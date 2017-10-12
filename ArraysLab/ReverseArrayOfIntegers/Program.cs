using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var thisArray = new int[n];

            for (int x = 0; x < n; x++)
            {
                thisArray[x] = int.Parse(Console.ReadLine()); 
            }
            for (int y = n - 1; y >= 0; y--)
            {
                Console.Write($"{thisArray[y]} ");
            }
            Console.WriteLine();



        }
    }
}
