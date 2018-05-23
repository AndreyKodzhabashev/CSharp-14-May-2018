using System;

namespace Ex03_Pr05_BooleanVariable
{
    class Ex03_Pr05_BooleanVariable
    {
        static void Main()
        {
            string text = Console.ReadLine();

            bool isTrue = Convert.ToBoolean(text);

            Console.WriteLine(isTrue ? "Yes" : "No");
        }
    }
}