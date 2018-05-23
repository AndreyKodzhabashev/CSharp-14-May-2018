using System;

namespace Ex03_Pr19_TeaThePhotogapher
{
    class Ex03_Pr19_TeaThePhotogapher
    {
        static void Main()
        {
            // 70/100 points solution. To be repaired!!!

            ulong takenPics = ulong.Parse(Console.ReadLine());

            ulong secsForFilter = ulong.Parse(Console.ReadLine());
            int percentGood = int.Parse(Console.ReadLine());
            int uploadTimeInSecs = int.Parse(Console.ReadLine());

            ulong totalSecsFilterTime = (takenPics * secsForFilter);
            double goodPics = (takenPics * 1.0 * percentGood / 100);
            goodPics = Math.Ceiling(goodPics);
            double totalUplTimeSecs = goodPics * uploadTimeInSecs;

            double totalTime = totalSecsFilterTime + totalUplTimeSecs;

            TimeSpan t = TimeSpan.FromSeconds((double)totalTime);

            string answer = string.Format($"{t.Days:D1}:{t.Hours:D2}:{t.Minutes:D2}:{t.Seconds:D2}");

            Console.WriteLine(answer);
        }
    }
}