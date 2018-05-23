using System;

namespace Ex02_Pr08_CaloriesCounter
{
    class Ex02_Pr08_CaloriesCounter
    {
        static void Main()
        {
            int countIngreds = int.Parse(Console.ReadLine());

            int totalCalories = 0;

            for (int i = 0; i < countIngreds; i++)
            {
                string ingredient = Console.ReadLine().ToLower();

                switch (ingredient)
                {
                    case "cheese":
                        totalCalories += 500;
                        break;
                    case "tomato sauce":
                        totalCalories += 150;
                        break;
                    case "salami":
                        totalCalories += 600;
                        break;
                    case "pepper":
                        totalCalories += 50;
                        break;
                }
                             
            }
            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
