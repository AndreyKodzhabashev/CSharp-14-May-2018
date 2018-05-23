using System;

namespace Ex02_Pr13_GameOfNumbers
{
    class Ex02_Pr13_GameOfNumbers
    {
        static void Main()
        {

            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            int magicalNum = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = firstNum; i <= secondNum; i++)
            {
                for (int j = firstNum; j <= secondNum; j++)
                {
                    counter++;

                    if (i + j == magicalNum)
                    {
                        Console.WriteLine($"Number found! {j} + {i} = {magicalNum}");
                        return;
                    }
                    
                }
            }

            Console.WriteLine($"{counter} combinations - neither equals {magicalNum}");
        }
    }
}