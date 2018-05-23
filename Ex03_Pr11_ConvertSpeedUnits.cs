using System;

namespace Ex03_Pr11_ConvertSpeedUnits
{
    class Ex03_Pr11_ConvertSpeedUnits
    {
        static void Main(string[] args)
        {
            int distMeter = int.Parse(Console.ReadLine());
            float distKM = (float)(distMeter * 1.0 / 1000);
            float distMls = (float)(distMeter * 1.0 / 1609);

            int hrs = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());
            int secs = int.Parse(Console.ReadLine());

            int totalSecs = secs + mins * 60 + hrs * 60 * 60;
            double timeHrs = totalSecs * 1.0 / 3600;

            float mPerSec = (float)(distMeter * 1.0 / totalSecs);
            float kmPerHr = (float)(distKM / timeHrs);
            float mlsPerHr = (float)(distMls / timeHrs);

            Console.WriteLine($"{mPerSec}");
            Console.WriteLine($"{kmPerHr}");
            Console.WriteLine($"{mlsPerHr}");
        }
    }
}
