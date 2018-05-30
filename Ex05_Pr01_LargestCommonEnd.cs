using System;
using System.Linq;

namespace Ex05_Pr01_LargestCommonEnd
{
    class Ex05_Pr01_LargestCommonEnd
    {
        static void Main(string[] args)
        {
            string[] arrFirstArray = Console.ReadLine().Split(' ').ToArray();
            string[] arrSecondArray = Console.ReadLine().Split(' ').ToArray();

            int counterFromStart = 0;

            for (int i = 0; i < Math.Min(arrFirstArray.Length, arrSecondArray.Length); i++)
            {
                if (arrFirstArray[i] != arrSecondArray[i])
                {
                    break;
                }
                counterFromStart++;
            }

            int counterFromEnd = 0;
            int lastFirstArayPosition = arrFirstArray.Length;
            lastFirstArayPosition--;
            int lastSecondArayPosition = arrSecondArray.Length;
            lastSecondArayPosition--;
            for (int i = 0; i < Math.Min(arrFirstArray.Length, arrSecondArray.Length); i++)
            {
                if (arrFirstArray[lastFirstArayPosition] != arrSecondArray[lastSecondArayPosition])
                {
                    break;
                }
                counterFromEnd++;
                lastFirstArayPosition--;
                lastSecondArayPosition--;
            }

            if (counterFromStart > counterFromEnd)
            {
                Console.WriteLine(counterFromStart);
            }
            else if (counterFromEnd>counterFromStart)
            {
                Console.WriteLine(counterFromEnd);
            }
            else
            {
                Console.WriteLine("0");
            }            
        }
    }
}
