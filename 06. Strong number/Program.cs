using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int numberSave = input;

            int currentNumber = 0;
            int factorialSum = 0;
            while (numberSave != 0)
            {
                currentNumber = numberSave % 10;
                numberSave /= 10;

                int factorial = 1;

                for (int i = 1; i <= currentNumber; i++)
                {
                    factorial *= i;
                }
                factorialSum += factorial;
            }
            string result = string.Empty;
            if (input == factorialSum)
            {
                result = "yes";
            }
            else
            {
                result = "no";
            }

            Console.WriteLine(result);
        }
    }
}
