using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int n = int.Parse(Console.ReadLine());
                int sum = 0;
                int num = -1;
                for (var x = 1; x <= n; x++)
                {
                    num += 2;
                    Console.WriteLine(num);
                    sum += num;
                }
                Console.WriteLine($"Sum: {sum}");

            }
        }
}
