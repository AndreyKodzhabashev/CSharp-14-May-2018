using System;

namespace Ex05_Pr06_PrimeChecker
{
    class Ex05_Pr06_PrimeChecker
    {
        static void Main()
        {
            Console.WriteLine(IsPrime(long.Parse(Console.ReadLine())));
        }

        private static string IsPrime (long n)
        {
            if (n == 0 || n == 1)
            {
                return "False";
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
               
                if (n % i == 0)
                {
                    return "False";
                }

            }
            return "True";
        }
    }
}
