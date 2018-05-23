using System;

namespace Ex02_Pr11_FiveDifferentNumbers
{
    class Ex02_Pr11_FiveDifferentNumbers
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            bool numberExist = false;

            for (int i = a; i <= b - 4; i++)
            {
                for (int j = a; j <= b - 3; j++)
                {
                    for (int k = a; k <= b - 2; k++)
                    {
                        for (int l = a; l <= b - 1; l++)
                        {
                            for (int m = a; m <= b; m++)
                            {
                                if (i < j && j < k && k < l && l < m)
                                {
                                    numberExist = true;
                                    Console.WriteLine($"{i} {j} {k} {l} {m}");
                                }
                            }
                        }
                    }
                }
            }
            if (numberExist == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}