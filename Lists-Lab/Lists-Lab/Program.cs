using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> newList = new List<int>();

           foreach (int num in input)
           {
               if (num > 0)
                   newList.Add(num);
          }
            newList.Reverse();

            if (newList.Count == 0)
            {
                Console.WriteLine("empty");
                return;
            }
            
                foreach (int number in newList)
                    Console.Write($"{number} ");
                Console.WriteLine();
            


        }
    }
}
