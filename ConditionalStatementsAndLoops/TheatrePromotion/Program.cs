using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatrePromotion
{
    class Program
    {
        static void Main(string[] args)
        {
                    public const int MIN_AGE = 0;
        public const int MAX_AGE = 122;

        static void Main(string[] args)
        {
            string dayType = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());
            int pricePerTicket = 0;



            if (age >= 0 && age <= 18)
            {
                switch (dayType)
                {
                    case "weekday":
                        pricePerTicket = 12;
                        break;
                    case "weekend":
                        pricePerTicket = 15;
                        break;
                    case "holiday":
                        pricePerTicket = 5;
                        break;
                }//switch
            }//if
            else if (age > 18 && age <= 64)
            {
                switch (dayType)
                {
                    case "weekday":
                        pricePerTicket = 18;
                        break;
                    case "weekend":
                        pricePerTicket = 20;
                        break;
                    case "holiday":
                        pricePerTicket = 12;
                        break;
                }//switch
            }//if
            else if (age > 64 && age <= 122)
            {
                switch (dayType)
                {
                    case "weekday":
                        pricePerTicket = 12;
                        break;
                    case "weekend":
                        pricePerTicket = 15;
                        break;
                    case "holiday":
                        pricePerTicket = 10;
                        break;
                }//switch
            }//if

            if (age < MIN_AGE || age > MAX_AGE)
            {
                Console.WriteLine("Error!");
            }

            else
            { Console.WriteLine($"{pricePerTicket}$"); }

        }
    }
}
