using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> thisList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int sum = 0;
            List<int> newList = new List<int>();

            for (int x = 0; x < thisList.Count; x++)
            {
                int reversed = 0;
                while (thisList[x] > 0)
                {
                    int right = thisList[x] % 10;
                    reversed = reversed * 10 + right;
                    thisList[x] = thisList[x] / 10;
                }
                sum += reversed;
            }
            Console.WriteLine(sum);

        }
    }
}
