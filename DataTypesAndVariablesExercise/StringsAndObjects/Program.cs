using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "Hello";
            string string2 = "World";

            object thisObject = $"{string1} {string2}";

            string string3 = (string)thisObject;
            Console.WriteLine(string3);
        }
    }
}
