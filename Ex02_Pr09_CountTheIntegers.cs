using System;

namespace Ex02_Pr09_CountTheIntegers
{
    class Ex02_Pr09_CountTheIntegers
    {
        static void Main()
        {
            int counter = 0;

            while (true)
            {
                try
                {
                    int a = int.Parse(Console.ReadLine());
                    counter++;
                }
                catch (Exception)
                {
                    break;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
