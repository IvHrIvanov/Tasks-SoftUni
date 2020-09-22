using System;

namespace _04._Print_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {

            int inputOne = int.Parse(Console.ReadLine());
            int inputTwo = int.Parse(Console.ReadLine());

            int sum = 0;

            for(int i=inputOne;i<=inputTwo;i++)
            {
                Console.Write(i + " ");
                sum += i;
            }

            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
