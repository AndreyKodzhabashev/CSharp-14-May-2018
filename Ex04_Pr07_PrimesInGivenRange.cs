using System;
using System.Collections.Generic;

namespace Ex05_Pr07_PrimesInGivenRange
{
    class Ex05_Pr07_PrimesInGivenRange
    {
        static void Main()
        {
            long start = long.Parse(Console.ReadLine());
            long end = long.Parse(Console.ReadLine());

            Console.WriteLine(string.Join(", ", ListOfPrimesInRange(start, end)));

        }
        static List<long> ListOfPrimesInRange(long a, long b)
        {
            List<long> listPrimes = new List<long>();

            for (long i = a; i <= b; i++)
            {
                if (IsPrime(i))
                {
                    listPrimes.Add(i);
                }


            }
            return listPrimes;
        }

        private static bool IsPrime(long n)
        {
            bool isPrime = true;
            if (n == 0 || n == 1)
            {
                isPrime = false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {

                if (n % i == 0)
                {
                    isPrime = false;
                }

            }
            return isPrime;
        }
    }
}
