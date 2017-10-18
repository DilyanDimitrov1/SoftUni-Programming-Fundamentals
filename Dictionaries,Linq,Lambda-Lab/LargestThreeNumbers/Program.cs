using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var sortedNumbers = input.OrderByDescending(x => x);
            var largest3Numbers = sortedNumbers.Take(3);

            Console.WriteLine(string.Join(" ", largest3Numbers));



        }
    }
}
