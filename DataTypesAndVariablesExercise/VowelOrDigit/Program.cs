using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int temp;

            if(int.TryParse(input, out temp))
            {
                Console.WriteLine("digit");
            }
            else if(input == "a" || input == "o" || input == "e" || input == "i" || input == "u")
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }

            
        }
    }
}
