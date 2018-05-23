using System;

namespace Ex02_Pr01__ChoseADrink
{
    class Ex02_Pr01__ChoseADrink
    {
        static void Main()
        {
            string profession = Console.ReadLine();
            string drink = "";

            switch (profession)
            {
                case "Athlete":
                    drink = "Water";
                    break;
                case "Businessman":
                case "Businesswoman":
                    drink = "Coffee";
                    break;
                case "SoftUni Student":
                    drink = "Beer";
                    break;
                default:
                    drink = "Tea";
                    break;
            }
            Console.WriteLine(drink);
        }
    }
}
