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

            while (true)
            {
                start = Console.ReadLine();
                if (start == "End")
                {
                    break;
                }
                double purchased = 0;

                switch (start)
                {
                    case "Coke":

                        purchased = coke;

                        if (purchased > sumCoint)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            break;
                        }

                        sumCoint -= coke;

                        Console.WriteLine($"Purchased {start.ToLower()}");

                        break;

                    case "Nuts":

                        purchased = nuts;

                        if (purchased > sumCoint)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            break;
                        }

                        sumCoint -= nuts;

                        Console.WriteLine($"Purchased {start.ToLower()}");

                        break;

                    case "Water":

                        purchased = water;

                        if (purchased > sumCoint)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            break;
                        }
                        sumCoint -= water;

                        Console.WriteLine($"Purchased {start.ToLower()}");

                        break;

                    case "Crisps":

                        purchased = crisps;

                        if (purchased > sumCoint)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            break;
                        }

                        sumCoint -= crisps;

                        Console.WriteLine($"Purchased {start.ToLower()}");

                        break;

                    case "Soda":

                        purchased = soda;

                        if (purchased > sumCoint)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            break;
                        }

                        sumCoint -= soda;

                        Console.WriteLine($"Purchased {start.ToLower()}");

                        break;

                    default:

                        Console.WriteLine("Invalid product");

                        break;
                }
            }
            Console.WriteLine($"Change: {sumCoint:f2}");
        }
    }
}