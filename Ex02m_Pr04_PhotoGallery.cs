using System;

namespace Ex02m_Pr4_PhotoGallery
{
    class Ex02m_Pr4_PhotoGallery
    {
        static void Main()
        {
            string photoName = Console.ReadLine();
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            long sizePic = long.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

           


            Console.WriteLine($"Name: DSC_{int.Parse(photoName):D4}.jpg");
            Console.WriteLine($"Date Taken: {day:D2}/{month:D2}/{year} {hour:D2}:{min:D2}");
           

            string sufix = SizeSuffix(sizePic,0);
            Console.WriteLine($"Size: {sufix}");
            string orientation = String.Empty;

            if (width == height)
            {
                orientation = "square";
            }
            else if (width < height)
            {
                orientation = "portrait";
            }
            else if (height < width)
            {
                orientation = "landscape";
            }


            Console.WriteLine($"Resolution: {width}x{height} ({orientation})");
            

        }
        static readonly string[] SizeSuffixes =
                  { "B", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };

        static string SizeSuffix(Int64 value, int decimalPlaces = 1)
        {
            if (value < 0) { return "-" + SizeSuffix(-value); }

            int i = 0;
            decimal dValue = (decimal)value;
            while (Math.Round(dValue, decimalPlaces) >= 1000)
            {
                dValue /= 1000;
                i++;
            }

            return string.Format("{0:n" + decimalPlaces +"}{1}", dValue, SizeSuffixes[i]);
        }
    }
}
