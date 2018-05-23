using System;

namespace Ex02_Pr10_TriangleOfNumbers
{
    class Ex02_Pr10_TriangleOfNumbers
    {
        static void Main()
        {
            int inputNum = int.Parse(Console.ReadLine());
            int digit = 0;

            for (int i = 1; i <= inputNum; i++)
            {
                digit = i;
                for (int j = 0; j < i; j++)
                {                                     
                    Console.Write(digit + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
