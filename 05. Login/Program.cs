using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {

            string user = Console.ReadLine();

            string password = "";
            int Length = 0;
            int stop = 0;
            Length = user.Length - 1;

            for (int a = 0; a < user.Length; a++)
            {
                password = password + user[Length];
                Length--;
            }

            while (true)
            {
                stop++;
                string input = Console.ReadLine();
                
                if (input == password)
                {
                    Console.WriteLine($"User {user} logged in.");
                    Environment.Exit(0);
                }
                if (stop == 4)
                {
                    Console.WriteLine($"User {user} blocked!");
                    break;

                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                
                
       
            }
            
        }
    }
}
