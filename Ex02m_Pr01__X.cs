using System;

namespace Ex02m_Pr01__X
{
    class Ex02m_Pr01__X
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int upperSpaces = n - 2;
            for (int i = 0; i < (n - 1) / 2; i++)
            {
                if (upperSpaces < 0)
                {
                    upperSpaces = 1;
                }
                Console.WriteLine(new string(' ', i) + "x" + new string(' ', upperSpaces) + "x");
                upperSpaces -= 2;
            }

            //print middle X
            Console.WriteLine(new string(' ', n / 2) + "x");

            int lowerSpaces = 1;
            for (int i = (n - 1) / 2; i > 0; i--)
            {
                Console.WriteLine(new string(' ', i - 1) + "x" + new string(' ', lowerSpaces) + "x");
                lowerSpaces += 2;
            }
        }
    }
}
