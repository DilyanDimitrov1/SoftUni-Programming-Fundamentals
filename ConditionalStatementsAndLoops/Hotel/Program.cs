using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double nights = double.Parse(Console.ReadLine());
            if (nights < MIN_NIGHTS || nights > MAX_NIGHTS)
            {
                Console.WriteLine("Error!");
            }
            double studioPricePerNight = 0.00;
            double doublePricePerNight = 0.00;
            double suitePricePerNight = 0.00;

            double totalStudioPrice = 0.00;
            double totalDoublePrice = 0.00;
            double totalSuitePrice = 0.00;



            switch (month)
            {
                case "May":
                case "October":
                    studioPricePerNight = 50.00;
                    doublePricePerNight = 65.00;
                    suitePricePerNight = 75.00;
                    break;
                case "June":
                case "September":
                    studioPricePerNight = 60.00;
                    doublePricePerNight = 72.00;
                    suitePricePerNight = 82.00;
                    break;
                case "July":
                case "August":
                case "December":
                    studioPricePerNight = 68.00;
                    doublePricePerNight = 77.00;
                    suitePricePerNight = 89.00;
                    break;
            }//switch

            if (nights > 7 && month == "May" || nights > 7 && month == "October")
                studioPricePerNight -= 0.05 * studioPricePerNight;

            else if (nights > 14 && month == "June" || nights > 14 && month == "September")
                doublePricePerNight -= 0.10 * doublePricePerNight;

            else if (nights > 14 && month == "July" || nights > 14
                    || nights > 14 && month == "December")
                suitePricePerNight -= 0.15 * suitePricePerNight;



            totalStudioPrice = nights * studioPricePerNight;
            totalDoublePrice = nights * doublePricePerNight;
            totalSuitePrice = nights * suitePricePerNight;

            if (nights > 7 && month == "September" || nights > 7 && month == "October")
                totalStudioPrice -= studioPricePerNight;


            Console.WriteLine($"Studio: {totalStudioPrice:f2} lv.");
            Console.WriteLine($"Double: {totalDoublePrice:f2} lv.");
            Console.WriteLine($"Suite: {totalSuitePrice:f2} lv.");

        }
    }
}
