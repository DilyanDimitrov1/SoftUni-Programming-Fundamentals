using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTriangleArea
{
    class Program
    {
        static double TriangleArea(double a, double b)
        {
            return a * b / 2; 
        }
        
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double area = TriangleArea(a, b);
            Console.WriteLine(area);
        }
    }
}
