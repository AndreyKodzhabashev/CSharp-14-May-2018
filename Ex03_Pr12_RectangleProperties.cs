using System;

namespace Ex03_Pr12_RectangleProperties
{
    class Ex03_Pr12_RectangleProperties
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double perim = 2 * width + 2 * height;
            double area = width * height;
            double diag = Math.Sqrt((Math.Pow(height, 2) + Math.Pow(width, 2)));

            Console.WriteLine(perim);
            Console.WriteLine(area);
            Console.WriteLine(diag);
        }
    }
}
