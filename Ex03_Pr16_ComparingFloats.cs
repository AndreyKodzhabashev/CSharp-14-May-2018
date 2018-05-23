using System;

namespace Ex03_Pr16_ComparingFloats
{
    class Ex03_Pr16_ComparingFloats

    {
        static void Main()
        {

            string firstFl = Console.ReadLine();
            string secondFl = Console.ReadLine();

            double floatA = double.Parse(firstFl);
            double floatB = double.Parse(secondFl);

            const double maxDiff = 0.000001;

            double actualDiff = Math.Abs(floatA - floatB);

            bool areEqual = true;

            if (actualDiff >= maxDiff)
            {
                areEqual = false;
            }

            Console.WriteLine(areEqual);
        }
    }
}