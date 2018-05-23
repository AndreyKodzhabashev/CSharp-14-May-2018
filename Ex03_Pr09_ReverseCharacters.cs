using System;
using System.Linq;
using System.Text;

namespace Ex03_Pr09_ReverseCharacters
{
    class Ex03_Pr09_ReverseCharacters
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 3; i++)
            {
                string input = Console.ReadLine();
                sb.Append(input);
            }
            
           string output = new string(sb.ToString().Reverse().ToArray());
            Console.WriteLine(output);
        }
    }
}
