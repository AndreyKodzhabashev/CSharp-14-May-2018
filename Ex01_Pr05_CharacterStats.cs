using System;

namespace Ex01_Pr05_CharacterStats
{
    class Ex01_Pr05_CharacterStats
    {
        static void Main()
        {
            string name = Console.ReadLine();

            int currentHealth = int.Parse(Console.ReadLine());
            int maximumHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maximumEnergy = int.Parse(Console.ReadLine());

            string pipeEnergy = new string('|', currentEnergy);
            string pipeHealth = new string('|', currentHealth);

            int leftEnergy = maximumEnergy - currentEnergy;
            int leftHealth = maximumHealth - currentHealth;

            string lEnergy = new string('.', leftEnergy);
            string lHealth = new string('.', leftHealth);

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{pipeHealth}{lHealth}|");
            Console.WriteLine($"Energy: |{pipeEnergy}{lEnergy}|");

        }
    }
}
