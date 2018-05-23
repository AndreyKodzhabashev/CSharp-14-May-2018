using System;

namespace Ex01_Pr04_BeverageLabels
{
    class Ex01_Pr04_BeverageLabels
    {
        static void Main()
        {
            string beverageName = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyPer100 = int.Parse(Console.ReadLine());
            int sugarContPer100 = int.Parse(Console.ReadLine());

            double totalEnergy = volume / 100.00 * energyPer100;
            double totalSugar = volume / 100.00 * sugarContPer100;

            Console.WriteLine($"{volume}ml {beverageName}");
            Console.WriteLine($"{totalEnergy}kcal, {totalSugar}g sugars");
        }
    }
}
