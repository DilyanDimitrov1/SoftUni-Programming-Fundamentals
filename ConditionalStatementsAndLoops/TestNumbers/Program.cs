using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int counter = 0;
            int max = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int x = N; x >= 1; x--)
            {
                for (int y = 1; y <= M; y++)
                {
                    if (sum >= max)
                        break;
                    sum += (x * y) * 3;
                    counter += 1;
                }//for

            }//for
            if (sum >= max)
            {
                Console.WriteLine($"{counter} combinations");
                Console.WriteLine($"Sum: {sum} >= {max}");
            }
            else
            {
                Console.WriteLine($"{counter} combinations");
                Console.WriteLine($"Sum: {sum}");
            }

        }
    }
}
