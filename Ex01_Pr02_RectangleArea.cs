using System;

namespace Ex01_Pr02_RectangleArea
{
    class Ex01_Pr02_RectangleArea
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double result = height * width;

            Console.WriteLine($"{result:f2}");
        }
    }
}
