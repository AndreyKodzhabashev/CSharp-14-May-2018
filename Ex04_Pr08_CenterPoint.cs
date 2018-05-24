using System;

namespace Ex05_Pr08_CenterPoint
{
    class Ex05_Pr08_CenterPoint
    {
        static void Main()
        {
            double firstPointX = double.Parse(Console.ReadLine());
            double firstPointY = double.Parse(Console.ReadLine());
            double secondPointX = double.Parse(Console.ReadLine());
            double secondPointY = double.Parse(Console.ReadLine());

            CenterPoint(firstPointX, firstPointY, secondPointX, secondPointY);

        }

        static void CenterPoint(double x1, double y1, double x2, double y2)
        {
            if (Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2)) <= Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2)))
                Console.WriteLine($"({x1}, {y1})");
            else
                Console.WriteLine($"({x2}, {y2})");

        }
    }
}
