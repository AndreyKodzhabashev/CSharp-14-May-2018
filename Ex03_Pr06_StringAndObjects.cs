using System;

namespace Ex03_Pr06_StringAndObjects
{
    class Ex03_Pr06_StringAndObjects
    {
        static void Main()
        {
            string first = "Hello";
            string second = "World";

            object text = first + " " + second;

            Console.WriteLine(text);
        }
    }
}