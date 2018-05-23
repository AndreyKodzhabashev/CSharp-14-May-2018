using System;

namespace Ex03_Pr13_VowelOrDigit
{
    class Ex03_Pr13_VowelOrDigit
    {
        static void Main()
        {
            string num = Console.ReadLine();
            string result = "other";
            try
            {
                int temp = int.Parse(num);
                result = "digit";
            }
            catch
            {
                char sym = char.Parse(num);
                int num1 = (int)sym;
                switch (num1)
                {
                    case 65:
                    case 69:
                    case 73:
                    case 79:
                    case 85:
                    case 89:
                    case 97:
                    case 101:
                    case 105:
                    case 111:
                    case 117:
                    case 121:
                        result = "vowel";
                        break;
                }
            }

            Console.WriteLine(result);
        }
    }
}