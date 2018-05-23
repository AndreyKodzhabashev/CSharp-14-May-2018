using System;

namespace Ex02_Pr15_NeighbourWars
{
    class Ex02_Pr15_NeighbourWars
    {
        static void Main()
        {
            int damagePesho = int.Parse(Console.ReadLine());
            int damageGosho = int.Parse(Console.ReadLine());

            int healthPesho = 100;
            int healthGosho = 100;

            bool areALive = true;
            int roundCounter = 1;

            while (areALive)
            {

                if (roundCounter % 2 == 0 == false)
                {
                    healthGosho -= damagePesho;

                    if (healthGosho <= 0)
                    {
                        Console.WriteLine($"{"Pesho"} won in {roundCounter}th round.");
                        return;
                    }

                    Console.WriteLine($"{"Pesho"} used {"Roundhouse kick"} and reduced {"Gosho"} to {healthGosho} health.");
                }
                else
                {
                    healthPesho -= damageGosho;

                    if (healthPesho <= 0)
                    {
                        Console.WriteLine($"{"Gosho"} won in {roundCounter}th round.");
                        return;
                    }

                    Console.WriteLine($"{"Gosho"} used {"Thunderous fist"} and reduced {"Pesho"} to {healthPesho} health.");
                }
               
                if (roundCounter % 3 == 0)
                {
                    healthPesho += 10;
                    healthGosho += 10;
                }

                roundCounter++;
            }
        }
    }
}