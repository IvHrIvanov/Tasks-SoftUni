using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {

            int lostGame = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int secondLost = 0;
            int thirdLost = 0;
            int secondKeyTrashed = 0;

            int sameLost = 0;
 

            double trashedHeadset = 0;
            double trashedMouse = 0;
            double trashedKeyboard = 0;
            double trashedDisplay = 0;


            for (int i = 0; i < lostGame; i++)
            {

                secondLost++;
                thirdLost++;

                if (secondLost == 2)
                {
                    sameLost++;
                    trashedHeadset += headsetPrice;
                    secondLost = 0;
                }
                if (thirdLost == 3)
                {
                    sameLost++;
                    trashedMouse += mousePrice;
                    thirdLost = 0;
                }
                if (sameLost == 5)
                {
                    trashedKeyboard += keyboardPrice;
                    sameLost = 0;
                   
                    secondKeyTrashed++;
                }
                if (secondKeyTrashed == 2)
                {
                    trashedDisplay += displayPrice;
                    secondKeyTrashed = 0;
                }

            }
            double totalSum = trashedDisplay + trashedHeadset + trashedKeyboard + trashedMouse;
            Console.WriteLine($"Rage expenses: {totalSum:f2} lv.");

        }
    }
}
