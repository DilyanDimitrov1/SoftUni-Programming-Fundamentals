using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double distanceOne = GetCloserPoint(x1, y1);
            double distanceTwo = GetCloserPoint(x2, y2);
            if (distanceOne < distanceTwo)
                Console.WriteLine($"({x1}, {y1})");
            else Console.WriteLine($"({x2}, {y2})");

        }
        public static double GetCloserPoint(double x, double y)
        {
            double point = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return point;
        }

    }
}

