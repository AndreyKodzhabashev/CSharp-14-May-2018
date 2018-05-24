using System;

namespace Ex05_Pr12_MasterNumbers
{
    class Ex05_Pr12_MasterNumbers
    {
        static void Main()
        {
            ulong end = ulong.Parse(Console.ReadLine());
            int count = 0;
            for (ulong i = 1; i <= end; i++)
            {
                if (IsPalindrome(i)
                    && IsSumDivisibleBy7(i)
                    && ContaintEvenDigit (i))
                {
                    Console.WriteLine(i);
                }
                count++;
            }            
        }

        private static bool IsSumDivisibleBy7(ulong num)
        {
            string temp = num.ToString();
            ulong sum = 0;
            bool divisibleBy7 = true;
            for (int i = 0; i <= temp.Length - 1; i++)
            {
                sum += uint.Parse(temp[i].ToString());
            }
            if (sum % 7 == 0 == false)
            {
                divisibleBy7 = false;
            }
            return divisibleBy7;
        }

        private static bool IsPalindrome(ulong num)
        {
            string temp = num.ToString();
            bool isPalindrome = true;
            int length = temp.Length;

            for (int i = 0; i < ((temp.Length) / 2); i++)
            {

                int a = temp[i];
                int b = temp[temp.Length - 1 - i];

                if (a == b == false)
                {
                    isPalindrome = false;
                    break;
                }
            }
            return isPalindrome;
        }

        private static bool ContaintEvenDigit(ulong num)
        {
            string temp = num.ToString();
            bool containsEvenDigit = false;
            if (temp.Contains("2") || temp.Contains("4") || temp.Contains("6") || temp.Contains("8") || temp.Contains("0") )
            {
                containsEvenDigit = true;
            }
            return containsEvenDigit;
        }
    }
}
