using System;

namespace Ex02_Pr05_WordInPlural
{
    class Ex02_Pr05_WordInPlural
    {
        static void Main()
        {
            string inputNoun = Console.ReadLine();
      
            if (inputNoun.EndsWith("y"))
            {
               inputNoun = inputNoun.Remove(inputNoun.Length - 1);
                inputNoun += "ies";
            }
            else if (inputNoun.EndsWith("o") || inputNoun.EndsWith("ch") || inputNoun.EndsWith("s") || inputNoun.EndsWith("sh") || inputNoun.EndsWith("x") || inputNoun.EndsWith("z"))
            {
                inputNoun += "es";
            }
            else
            {
                inputNoun += "s";
            }
            Console.WriteLine(inputNoun);
        }
    }
}
