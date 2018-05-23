using System;
using System.Collections.Generic;

namespace Ex03_Pr07_ExchangeVariableValues
{
    class Ex03_Pr07_ExchangeVariableValues
    {
        static void Main()
        {

            int letter = 97;

            List<int> nums = new List<int>{ 5, 10 };

            Console.WriteLine("Before:");

            foreach (var item in nums)
            {
                Console.WriteLine($"{(char)letter} = {item}");
                letter++;
            }

            letter = 97;

            nums.Reverse();
            Console.WriteLine("After:");

            foreach (var item in nums)
            {
                Console.WriteLine($"{(char)letter} = {item}");
                letter++;
            }
            
        }
    }
}