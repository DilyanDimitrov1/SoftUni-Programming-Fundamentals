using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintPartsOfTheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
           int char1 = int.Parse(Console.ReadLine());
           int char2 = int.Parse(Console.ReadLine());
           
           for(int x = char1; x <= char2; x++)
           {
               Console.Write($"{(char)x} ");
           }



        }
    }
}
