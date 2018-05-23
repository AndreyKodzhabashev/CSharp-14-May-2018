using System;

namespace Ex02_Pr12_TestNumbers
{
    class Ex02_Pr12_TestNumbers
    {

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());

            int totalResult = 0;
            int counter = 0;
            for (int i = n; i > 0; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    totalResult += (i * j) * 3;
                    counter++;

                    if (totalResult >= maxSum)
                    {
                        break;
                    }
                }
                if (totalResult >= maxSum)
                {
                    break;
                }
            }
            if (totalResult >= maxSum)
            {
                Console.WriteLine($"{counter} combinations");
                Console.WriteLine($"Sum: {totalResult} >= {maxSum}");
            }
            else
            {
                Console.WriteLine($"{counter} combinations");
                Console.WriteLine($"Sum: {totalResult}");
            }
        }
    }
}