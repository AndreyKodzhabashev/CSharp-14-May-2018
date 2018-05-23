using System;

namespace Ex03_Pr04_VariableInHexadecimalFormat
{
    class Ex03_Pr04_VariableInHexadecimalFormat
    {
        static void Main()
        {
            string a = Console.ReadLine();

            int convertedHex = Convert.ToInt32(a, 16);

            Console.WriteLine(convertedHex);
        }
    }
}