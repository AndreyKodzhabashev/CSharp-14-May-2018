using System;

namespace Ex05_Pr11_GeometryCalculator
{
    class Ex05_Pr11_GeometryCalculator
    {
        static void Main()
        {
            string figureType = Console.ReadLine();

            switch (figureType)
            {
                case "triangle":
                    double side = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    TriangleAreaa(side, height);
                    break;
                case "rectangle":
                    double sideA = double.Parse(Console.ReadLine());
                    double sideB = double.Parse(Console.ReadLine());
                    RectangleArea(sideA, sideB);
                    break;
                case "square":
                    double sideSq = double.Parse(Console.ReadLine());
                    SquareArea(sideSq);
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    CircleArea(radius);
                    break;
            }
        }

        private static void CircleArea(double radius)
        {
            Console.WriteLine($"{(Math.PI * Math.Pow(radius, 2)):f2}");
        }

        private static void SquareArea(double sideSq)
        {
            Console.WriteLine($"{Math.Pow(sideSq, 2):f2}");
        }

        private static void RectangleArea(double sideA, double sideB)
        {
            Console.WriteLine($"{(sideA * sideB):f2}");
        }

        private static void TriangleAreaa(double side, double height)
        {
            Console.WriteLine($"{((side * height) / 2):f2}");
        }
    }
}
