using System;

namespace Ex05_Pr01_HelloName
{
    class Ex05_Pr01_HelloName
    {
        static void Main()
        {
            GreetByName(Console.ReadLine());
        }
        static void GreetByName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}