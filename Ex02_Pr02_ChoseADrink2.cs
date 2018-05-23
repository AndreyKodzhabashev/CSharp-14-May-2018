using System;

namespace Ex02_Pr02_ChoseADrink2
{
    class Ex02_Pr02_ChoseADrink2
    {
        static void Main()
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            string drink = "";
            double price = 0;

            switch (profession)
            {
                case "Athlete":
                    drink = "Water";
                    price = 0.7;
                    break;
                case "Businessman":
                case "Businesswoman":
                    drink = "Coffee";
                    price = 1;
                    break;
                case "SoftUni Student":
                    drink = "Beer";
                    price = 1.7;
                    break;
                default:
                    drink = "Tea";
                    price = 1.20;
                    break;
            }
            
            double totalPrice = quantity * 1.0 * price;
            Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
        }
    }
}
