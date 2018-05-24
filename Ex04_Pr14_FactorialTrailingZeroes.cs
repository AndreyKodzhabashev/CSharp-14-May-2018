using System;
using System.Linq;
using System.Numerics;

namespace Ex05_Pr14_FactorialTrailingZeroes
{
    class Ex05_Pr14_FactorialTrailingZeroes
    {
        static void Main()
        {
            
            Console.WriteLine(CountTrailingZeros(Factorial(int.Parse(Console.ReadLine()))));
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
        private static int CountTrailingZeros(BigInteger num)
        {
            string temp = num.ToString();
            int counter = 0;
            for (int i = temp.Length -1; i >=0; i--)
            {
               
                if (temp[i].ToString().Equals("0") )
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }
            return counter;
        }
    }
}
