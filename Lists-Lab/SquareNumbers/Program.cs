using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> thisList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> newList = new List<int>();

            foreach (int num in thisList)
            {
                if(Math.Sqrt(num) == (int)Math.Sqrt(num))
                    newList.Add(num);
            }
            newList.Sort();
            newList.Reverse();

            Console.WriteLine(string.Join(" ", newList));

        }
    }
}
