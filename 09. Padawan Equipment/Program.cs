using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {

            double moneyHas = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceLightsabers = double.Parse(Console.ReadLine());
            double priceRobes = double.Parse(Console.ReadLine());
            double priceBelts = double.Parse(Console.ReadLine());



            int beltsDiscStud = students;
            int beltsFree = 0;

            double lightsabMoreMoney = Math.Ceiling(students + (students * 0.10));
            for (int i = 0; i < students; i++)
            {
                beltsFree++;
                if (beltsFree == 6)
                {
                    beltsDiscStud--;
                    beltsFree = 0;
                }

            }
            double totalSum = priceLightsabers * lightsabMoreMoney + priceRobes * students + priceBelts * beltsDiscStud;

            if (moneyHas >= totalSum)
            {
                Console.WriteLine($"The money is enough - it would cost {totalSum:f2}lv.");
            }
            else
            {
                double moneyNeed = totalSum - moneyHas;
                Console.WriteLine($"Ivan Cho will need {moneyNeed:f2}lv more.");
            }

        }
    }
}
