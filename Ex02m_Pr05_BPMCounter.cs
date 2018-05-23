using System;
using System.Numerics;

namespace Ex02m_Pr05_BPMCounter
{
    class Ex02m_Pr05_BPMCounter
    {
        static void Main()
        {


            int bpm = int.Parse(Console.ReadLine());
            int numOfBeats = int.Parse(Console.ReadLine());



            double temp = numOfBeats * 1.0 / 4;
            double totalSecs = numOfBeats * 1.0 / bpm * 60;

            TimeSpan t = TimeSpan.FromSeconds(totalSecs);

            Console.WriteLine($"{Math.Round(temp, 1)} bars - {t.Minutes}m {t.Seconds}s");


        }
    }
}
