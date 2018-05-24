using System;
using System.Numerics;

namespace Ex05_Pr05_FibonacciNumbers
{
    class Ex05_Pr05_FibonacciNumbers
    {
        static void Main()
        {
            BigInteger num = BigInteger.Parse(Console.ReadLine());

            Console.WriteLine(FibonacciNumber(num));
        }

        static BigInteger FibonacciNumber(BigInteger num)
        {
            BigInteger result = 0;

            if (num == 0 || num == 1)
            {
                return 1;             
            }
           
            BigInteger firstFibo = 0;
            BigInteger secondFibo = 1;
            for (int i = 1; i <= num; i++)
            {
                result = firstFibo + secondFibo;
                firstFibo = secondFibo;
                secondFibo = result;
            }

            return result;
        }
    }
}
