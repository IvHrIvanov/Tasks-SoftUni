using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {

            double studentsFriday = 8.45;
            double bussinesFriday = 10.90;
            double regularFriday = 15;

            double studentsSaturday = 9.80;
            double businessSaturday = 15.60;
            double regulraSaturday = 20;

            double studentsSunday = 10.46;
            double businessSunday = 16;
            double regulraSunday = 22.50;

            int inputPeople = int.Parse(Console.ReadLine());
            string typeOfPeople = Console.ReadLine();
            string dayOfWeak = Console.ReadLine();

            double price = 0;

            if (typeOfPeople == "Students")
            {
                switch (dayOfWeak)
                {
                    case "Friday":
                        price += studentsFriday;
                        break;
                    case "Saturday":
                        price += studentsSaturday;
                        break;
                    case "Sunday":
                        price += studentsSunday;
                        break;
                }
            }

            else if (typeOfPeople == "Business")
            {
                switch (dayOfWeak)
                {
                    case "Friday":
                        price += bussinesFriday;
                        break;
                    case "Saturday":
                        price += businessSaturday;
                        break;
                    case "Sunday":
                        price += businessSunday;
                        break;
                }
            }

            else if (typeOfPeople == "Regular")
            {
                switch (dayOfWeak)
                {
                    case "Friday":
                        price += regularFriday;
                        break;
                    case "Saturday":
                        price += regulraSaturday;
                        break;
                    case "Sunday":
                        price += regulraSunday;
                        break;
                }
            }

            double totalPrice = inputPeople * price;

            if (inputPeople >= 30 && typeOfPeople == "Students")
            {
                totalPrice -= totalPrice * 0.15;
            }

            else if (inputPeople >= 100 && typeOfPeople == "Business")
            {
                totalPrice -= 10 * price;
            }

            else if (inputPeople >= 10 && inputPeople <= 20 && typeOfPeople == "Regular")
            {
                totalPrice -= totalPrice * 0.05;
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");

        }
    }
}