using System;
using System.Numerics;

namespace Ex05_Pr13_Factorial
{
    class Ex05_Pr13_Factorial
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(Factorial(num));

        }

        private static BigInteger Factorial(int num)
        {

            BigInteger factorial = 1;
            if (num == 0)
            {
                factorial = 0;

            }
            else if (num == 1 || num == 2)
            {
                factorial = 1;
            }
            else
            {
               
                for (int i = 1; i <= num; i++)
                {
                    factorial *= i;
                }
            }
            return factorial;
        }
    }
}
