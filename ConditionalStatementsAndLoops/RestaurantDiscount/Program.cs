using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            double groupSize = double.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            string hall = null;
            double packagePrice = 0.00;
            double hallPrice = 0.00;
            double discount = 0.00;


            switch (package)
            {
                case "Normal":
                    packagePrice = 500;
                    discount = 0.05;
                    break;
                case "Gold":
                    packagePrice = 750;
                    discount = 0.10;
                    break;
                case "Platinum":
                    packagePrice = 1000;
                    discount = 0.15;
                    break;

            }//switch


            if (groupSize <= 50)
            {
                hall = "Small Hall";
                hallPrice = 2500;
            }

            else if (groupSize > 50 && groupSize <= 100)
            {
                hall = "Terrace";
                hallPrice = 5000;
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                hall = "Great Hall";
                hallPrice = 7500;
            }
            else if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }
            double totalPrice = hallPrice + packagePrice;

            double finalPrice = totalPrice - (totalPrice * discount);
            double pricePerPerson = finalPrice / groupSize;

            Console.WriteLine($"We can offer you the {hall}");
            Console.WriteLine($"The price per person is {pricePerPerson:f2}$");

        }
    }
}
