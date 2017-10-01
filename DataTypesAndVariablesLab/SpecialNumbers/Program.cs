using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int x = 1; x <= n; x++)
            {
                int lastDigit = x % 10;
                int beforeDigits = x / 10;
                sum = lastDigit + beforeDigits;
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{x} -> True");
                }
                else
                {
                    Console.WriteLine($"{x} -> False");
                }
                    

            }
        }
    }

}
