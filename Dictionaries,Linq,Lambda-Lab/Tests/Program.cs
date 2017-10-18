using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new List<string>
            {
                "Pesho", "Maria", "Kiro", "Mimi",
                "Atanas"
            };
            var longName = nums.Where(x => x.Length > 4);
            Console.WriteLine(string.Join(Environment.NewLine, longName));





        }

        static bool Over25(int x)
        {
            return x > 25;
        }
    }
}
