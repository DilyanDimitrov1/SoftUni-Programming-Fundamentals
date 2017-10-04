using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1 = float.Parse(Console.ReadLine());
            float num2 = float.Parse(Console.ReadLine());

            var diff = Math.Abs(num1 - num2);

            bool check = diff < 0.000001;

            Console.WriteLine(check);


        }
    }
}
