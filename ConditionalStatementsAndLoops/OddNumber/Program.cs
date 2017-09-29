using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int n = 1;

            while (n < 10)

                if (num % 2 == 0)
                {
                    n++;
                    Console.WriteLine("Please write an odd number.");
                    num = int.Parse(Console.ReadLine());
                }

                else
                {
                    Console.WriteLine($"The number is: {Math.Abs(num)}");
                    break;
                }

        }
    }
}
