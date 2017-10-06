using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(GetFibonacci(n));

        }

        static long GetFibonacci(int n)
        {
            long num1 = 0;
            long num2 = 1;
            


            for (int i = 0; i < n; i++)
            {
                long num3 = num1 + num2;
                num1 = num2;
                num2 = num3;
            }
            return num2;
        }


    }
}
