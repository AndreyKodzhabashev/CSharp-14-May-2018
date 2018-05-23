using System;

namespace Ex03_Pr15_FastPrimeChacker_Refactor
{
    class Ex03_Pr15_FastPrimeChacker_Refactor
    {
        static void Main()
        {
            int sequenceEnd = int.Parse(Console.ReadLine());

            for (int numForCheck = 2; numForCheck <= sequenceEnd; numForCheck++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(numForCheck); j++)
                {
                    if (numForCheck % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{numForCheck} -> {isPrime}");
            }
        }
    }
}
