using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int x = 2; x <= input; x++)
            {
                bool prime = true;
                for (int y = 2; y <= Math.Sqrt(x); y++)
                {
                    if (x % y == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                Console.WriteLine($"{x} -> {prime}");
            }

        }
    }
}
