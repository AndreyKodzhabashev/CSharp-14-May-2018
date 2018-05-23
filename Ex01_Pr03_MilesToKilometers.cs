using System;

namespace Ex01_Pr03_MilesToKilometers
{
    class Ex01_Pr03_MilesToKilometers
    {
        static void Main()
        {
            double kilometers = double.Parse(Console.ReadLine());

            double toMiles = 1.60934;

            double convertedKM = kilometers * toMiles;

            Console.WriteLine($"{convertedKM:f2}");
        }
    }
}
