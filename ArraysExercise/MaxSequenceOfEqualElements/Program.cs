using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] thisArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int sequenceCounter = 0;
            int currentLongestSequence = 0;
            int currentBestStart = 0;


            for (int x = 0; x < thisArray.Length - 1; x++)
            {
                if (thisArray[x] == thisArray[x + 1])
                {
                    sequenceCounter++;
                    if (sequenceCounter > currentLongestSequence)
                    {
                        currentLongestSequence = sequenceCounter;
                        currentBestStart = x - sequenceCounter;
                    }
                }
                else
                {
                    sequenceCounter = 0;
                }
            }//for

            for (int y = currentBestStart + 1; y <= currentBestStart + currentLongestSequence + 1; y++)
            {
                Console.Write($"{thisArray[y]} ");
            }
        }
    }
}
