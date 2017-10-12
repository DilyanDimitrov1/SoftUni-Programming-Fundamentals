using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitByWordCasing
{
    class Program
    {

        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(
                    new char[] {',', ';', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ', ':'},
                    StringSplitOptions.RemoveEmptyEntries)
                .ToList();


            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCase = new List<string>();


          CaseChecker(input, upperCase, lowerCase, mixedCase);


            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");

        }

        private static void CaseChecker(List<string>input, List<string>upperCase, List<string>lowerCase,List<string>mixedCase)
        {
            foreach (string element in input)
            {
                if (element.All(char.IsUpper))
                    upperCase.Add(element);
                else if (element.All(char.IsLower))
                    lowerCase.Add(element);
                else
                {
                    mixedCase.Add(element);
                }
            }
        }
    }
}

