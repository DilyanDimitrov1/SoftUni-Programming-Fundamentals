using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> thisList = Console.ReadLine()
                .Split(' ')
                .Select(decimal.Parse)
                .ToList();

            thisList.Sort();

            Console.WriteLine(string.Join(" <= ", thisList));
        }
    }
}
