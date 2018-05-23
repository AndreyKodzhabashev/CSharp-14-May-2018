using System;
using System.Numerics;

namespace Ex02m_Pr07_TrainingHallEquipment
{
    class Ex02m_Pr07_TrainingHallEquipment
    {
        static void Main()
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            byte numItems = byte.Parse(Console.ReadLine());

            decimal subtotal = 0;

            for (byte i = 0; i < numItems; i++)
            {
                string itemName = Console.ReadLine();
                float itemPrice = float.Parse(Console.ReadLine());
                ushort quantityItem = ushort.Parse(Console.ReadLine());

                if (quantityItem == 1 == false)
                {
                    itemName = itemName.Insert(itemName.Length, "s");
                }

                Console.WriteLine($"Adding {quantityItem} {itemName} to cart.");

                subtotal = subtotal + (quantityItem * (decimal)itemPrice);

            }

            Console.WriteLine($"Subtotal: ${subtotal}");
            if (subtotal <= budget)
            {
                Console.WriteLine($"Money left: ${(budget - subtotal):f2}");
            }
            else
            {
                Console.WriteLine($"Not enough. We need ${(subtotal - budget):f2} more.");
            }
        }
    }
}
