using System;

namespace Ex02_Pr06_InttervalOfNumbers
{
    class Ex02_Pr06_InttervalOfNumbers
    {
        static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            int smallerNum = Math.Min(firstNum, secondNum);
            int bigerNum = Math.Max(firstNum, secondNum);

            for (int i = smallerNum; i <= bigerNum; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}