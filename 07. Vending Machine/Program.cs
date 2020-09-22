using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            double nuts = 2.0;
            double water = 0.7;
            double crisps = 1.5;
            double soda = 0.8;
            double coke = 1.0;

            double insertCoint = double.Parse(Console.ReadLine());

            string start = " ";
            double sumCoint = 0;

            while (true)
            {


                if (insertCoint == 0.1 || insertCoint == 0.2 || insertCoint == 0.5 || insertCoint == 1 || insertCoint == 2)
                {
                    sumCoint += insertCoint;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {insertCoint}");

                }

                start = Console.ReadLine();
                if (start == "Start")
                {
                    break;
                }
                insertCoint = double.Parse(start);




            }

            while (start != "End")
            {
                start = Console.ReadLine();
                double purchased = 0;
                if (purchased < 0.7)
                {
                    Console.WriteLine("Sorry, not enough money");
                    continue;
                }
                switch (start)
                {
                    case "Coke":
                        sumCoint -= coke;
                        Console.WriteLine("Purchased coke");
                        break;
                    case "Nuts":
                        sumCoint -= nuts;
                        Console.WriteLine("Purchased nuts");
                        break;
                    case "Water":
                        sumCoint -= water;
                        Console.WriteLine("Purchased water");
                        break;
                    case "Crisps":
                        purchased = crisps;
                        if (purchased > sumCoint)
                        {
                            continue;
                        }
                        sumCoint -= crisps;
                        Console.WriteLine("Purshased crisps");
                        break;
                    case "Soda":
                        sumCoint -= soda;
                        Console.WriteLine("Purchased soda");
                        break;


                }


            }

        }
    }
}
