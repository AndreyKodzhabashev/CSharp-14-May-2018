using System;

namespace Ex03_Pr17_PrintPartOfAsciiTable
{
    class Ex03_Pr17_PrintPartOfAsciiTable
    {
        static void Main()
        {
            int startIndex = int.Parse(Console.ReadLine());
            int endIndex = int.Parse(Console.ReadLine());

            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.Write((char)i + " ");
            }

        }
    }
}
