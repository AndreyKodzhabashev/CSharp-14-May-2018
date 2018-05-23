using System;

namespace Ex03_Pr08_EmployeeData
{
    class Ex03_Pr08_EmployeeData
    {
        static void Main()
        {
            string firstName = Console.ReadLine();
            string surName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            ulong personalID = ulong.Parse(Console.ReadLine());
            uint emplNum = uint.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {surName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal ID: {personalID}");
            Console.WriteLine($"Unique Employee number: {emplNum}");

        }
    }
}