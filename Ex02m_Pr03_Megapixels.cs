using System;

namespace Ex02m_Pr03_Megapixels
{
    class Ex02m_Pr03_Megapixels
    {
        static void Main()
        {
            int widthPic = int.Parse(Console.ReadLine());
            int heightPic = int.Parse(Console.ReadLine());

            int result = widthPic * heightPic;

            double mgpxls = result / 1000000.0;

            mgpxls = Math.Round(mgpxls, 1);

            Console.WriteLine($"{widthPic}x{heightPic} => {mgpxls}MP");
        }
    }
}
