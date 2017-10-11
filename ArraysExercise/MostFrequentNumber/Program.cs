using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort[] thisArray = Console.ReadLine()
                .Split(' ')
                .Select(ushort.Parse)
                .ToArray();

            int[] counter = new int[65535];

            foreach (ushort num in thisArray)
            {
                counter[num]++;
            }
            int max = counter.Max();


            for (int x = 0; x < thisArray.Length; x++)
            {
                if (counter[thisArray[x]] == max)
                {
                    Console.WriteLine(thisArray[x]);
                    return;
                }
            }

            

        }
    }
}
