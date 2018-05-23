using System;

namespace Ex02_Pr07_CakeIngredients
{
    class Ex02_Pr07_CakeIngredients
    {
        static void Main()
        {
            int counter = 0;

            while (true)
            {

                string inputText = Console.ReadLine();

                if (inputText.Equals("Bake!", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine($"Preparing cake with {counter} ingredients.");
                    return;
                }

                Console.WriteLine($"Adding ingredient {inputText}.");
                counter++;
            }                       
        }
    }
}
