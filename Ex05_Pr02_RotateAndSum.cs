using System;
using System.Linq;

namespace Ex05_Pr02_RotateAndSum
{
    class Ex05_Pr02_RotateAndSum
    {
        static void Main()
        {
            int[] arrNum = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());

            int[] arrSum = new int[arrNum.Length];

            for (int i = 0; i < k; i++)
            {
                arrNum = ArrReversedToRight(arrNum);
                for (int j = 0; j < arrNum.Length; j++)
                {
                    arrSum[j] += arrNum[j];
                }
            }

            Console.WriteLine(string.Join(" ", arrSum));
        }
        static int[] ArrReversedToRight(int[] Array)
        {
            int tempNum = Array[Array.Length - 1];
            for (int i = Array.Length - 1; i > 0; i--)
            {
                Array[i] = Array[i - 1];
            }
            Array[0] = tempNum;
            return Array;
        }
        static int[] ReplaceIntArrayByValues(int[] array)
        {
            int[] intByValues = new int[array.Length];
            int currentNumber = 0;

            for (int i = 0; i < array.Length; i++)
            {
                currentNumber = array[i];
                intByValues[i] = currentNumber;
            }
            return intByValues;
        }
    }
}