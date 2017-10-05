using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPower
{
    class Program
    {
        static double RaiseNumberToPower(double input, double power)
        {
            return Math.Pow(input, power);             
        }

        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            double powered = RaiseNumberToPower(input, power);
            Console.WriteLine(powered);

        }
    }
}
