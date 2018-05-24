using System;

namespace Ex05_Pr02_MaxMethod
{
    class Ex05_Pr02_MaxMethod
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(a, GetMax(b, c)));

        }

        static double GetMax(double a, double b)
        {
            if (a > b)
            {
                return a;

            }
            else
            {
                return b;
            }
        }
    }
}
