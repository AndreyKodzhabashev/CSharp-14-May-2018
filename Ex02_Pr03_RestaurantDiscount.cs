using System;

namespace Ex02_Pr03_RestaurantDiscount
{
    class Ex02_Pr03_RestaurantDiscount
    {
        static void Main()
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine().ToLower();

            double price = 0;

            double discount = 0;
            string hallName = "";

            if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            if (groupSize <= 50)
            {
                hallName = "Small Hall";
                price = 2500;
            }
            else if (groupSize <= 100)
            {
                hallName = "Terrace";
                price = 5000;
            }
            else
            {
                hallName = "Great Hall";
                price = 7500;
            }

            switch (package)
            {
                case "normal":
                    price += 500;
                    discount = 5 * 1.0 / 100;
                    break;
                case "gold":
                    price += 750;
                    discount = 10 * 1.0 / 100;
                    break;
                case "platinum":
                    price += 1000;
                    discount = 15 * 1.0 / 100;
                    break;
            }

            double result = (price - (price * discount)) / groupSize;

            Console.WriteLine($"We can offer you the {hallName}");
            Console.WriteLine($"The price per person is {result:f2}$");
        }
    }
}
