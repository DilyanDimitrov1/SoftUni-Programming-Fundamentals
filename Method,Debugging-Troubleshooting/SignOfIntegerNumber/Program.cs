using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignOfIntegerNumber
{
    class Program
    {
        static void SignChecker()
        {
                int n = int.Parse(Console.ReadLine());
                if (n == 0)
                {
                    Console.WriteLine($"The number {n} is zero.");
                    return;
                }
                else if (n > 0)
                {
                    Console.WriteLine($"The number {n} is positive.");
                    return;
                }
                else if (n < 0)
                {
                    Console.WriteLine($"The number {n} is negative.");
                    return;
                
            }
        }

        static void Main(string[] args)
        {
            SignChecker();
        }

    }
}
