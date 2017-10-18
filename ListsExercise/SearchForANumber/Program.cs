using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            bool checker = true; 
            List<int> thisList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int[] thisArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            List<int> newList = new List<int>();

            for (int x = 0; x < thisArray[0]; x++)
            {
                newList.Add(thisList[x]);
            }
            for (int y = 0; y < thisArray[1]; y++)
            {
                newList.RemoveAt(0);
            }

            if(newList.Contains(thisArray[2]))
                Console.WriteLine("YES!");
            else
            {
                Console.WriteLine("NO!");
            }

            
        }
    }
}
