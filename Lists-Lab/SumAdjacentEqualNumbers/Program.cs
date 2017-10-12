using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> thisList = Console.ReadLine()
                .Split(' ')
                .Select(decimal.Parse)
                .ToList();
            decimal sum = 0.0m; 
            for (int x = 1; x < thisList.Count; x++)
            {
                if (thisList[x-1] == thisList[x])
                {
                    thisList[x] = thisList[x] + thisList[x - 1];
                    thisList.RemoveAt(x - 1);
                    x = 0;
                }
            }
            Console.WriteLine(string.Join(" ", thisList));

        }
    }
}
