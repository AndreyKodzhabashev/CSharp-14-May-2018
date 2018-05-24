using System;
using System.Text;

namespace Ex05_Pr04_NumbersInReversedOrder
{
    class Ex05_Pr04_NumbersInReversedOrder
    {
        static void Main()
        {
            Console.WriteLine(ReversedOrder(Console.ReadLine()));
        }
        static string ReversedOrder(string text)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = text.Length - 1; i >= 0; i--)
            {
                sb.Append(text[i]);
            }

            return sb.ToString();
        }
    }
}
