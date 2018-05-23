using System;

namespace Ex03_Pr14_IntegerToHexAndBinary
{
    class Ex03_Pr14_IntegerToHexAndBinary
    {
        static void Main()
        {
            int numForConv = int.Parse(Console.ReadLine());

            string convNumHex = System.Convert.ToString(numForConv, 16).ToUpper();
            string convNumBinary = System.Convert.ToString(numForConv, 2);

            Console.WriteLine(convNumHex);
            Console.WriteLine(convNumBinary);
        }
    }
}