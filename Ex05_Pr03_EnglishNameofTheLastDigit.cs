using System;

namespace Ex05_Pr03_EnglishNameofTheLastDigit
{
    class Ex05_Pr03_EnglishNameofTheLastDigit

    {
        static void Main()
        {

            string num = Console.ReadLine();
            Console.WriteLine(LastDigitAsText(num));

        }

        static string LastDigitAsText(string num)
        {
            int a = int.Parse(num[num.Length - 1].ToString());
            string result = string.Empty;

            switch (a)
            {
                case 0:
                    result = "zero";
                    break;
                case 1:
                    result = "one";
                    break;
                case 2:
                    result = "two";
                    break;
                case 3:
                    result = "three";
                    break;
                case 4:
                    result = "four";
                    break;
                case 5:
                    result = "five";
                    break;
                case 6:
                    result = "six";
                    break;
                case 7:
                    result = "seven";
                    break;
                case 8:
                    result = "eight";
                    break;
                case 9:
                    result = "nine";
                    break;
            }

            return result;
        }
    }
}
