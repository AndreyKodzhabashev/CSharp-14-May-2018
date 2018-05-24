using System;

namespace Ex05_Pr10_CubeProperties
{
    class Ex05_Pr10_CubeProperties
    {
        static void Main()
        {
            double cubeSide = double.Parse(Console.ReadLine());
            string propertie = Console.ReadLine();

            switch (propertie)
            {
                case "face":
                    CubeFace(cubeSide);
                    break;
                case "space":
                    CubeSpace(cubeSide);
                    break;
                case "volume":
                    CubeVolume(cubeSide);
                    break;
                case "area":
                    CubeArea(cubeSide);
                    break;

            }

        }
        static void CubeFace(double side)
        {
            Console.WriteLine($"{Math.Sqrt(2 * Math.Pow(side, 2)):f2}");
        }
        static void CubeSpace(double side)
        {
            Console.WriteLine($"{Math.Sqrt(3 * Math.Pow(side, 2)):f2}");
        }
        static void CubeVolume(double side)
        {
            Console.WriteLine($"{Math.Pow(side, 3):f2}");
        }
        static void CubeArea(double side)
        {
            Console.WriteLine($"{(6 * Math.Pow(side, 2)):f2}");
        }
    }
}
