using System;
using System.Text;

namespace Ex03_Pr18_DifferentIntegerSize
{
    class Ex03_Pr18_DifferentIntegerSize
    {
        static void Main()
        {
            string inputNumAsText = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            try
            {
                sbyte temp = sbyte.Parse(inputNumAsText);
                sb.AppendLine("* sbyte");
            }
            catch (Exception)
            {
                                
            }

            try
            {
                byte temp = byte.Parse(inputNumAsText);
                sb.AppendLine("* byte");
            }
            catch (Exception)
            {
               
            }

            try
            {
                short temp = short.Parse(inputNumAsText);
                sb.AppendLine("* short");
            }
            catch (Exception)
            {

            }
            
            try
            {
                ushort temp = ushort.Parse(inputNumAsText);
                sb.AppendLine("* ushort");
            }
            catch (Exception)
            {
                
            }

            try
            {
                int temp = int.Parse(inputNumAsText);
                sb.AppendLine("* int");
            }
                catch (Exception)
            {
                               
            }

            try
            {
                uint temp = uint.Parse(inputNumAsText);
                sb.AppendLine("* uint");
            }
            catch (Exception)
            {
                
            }
            try
            {
                long temp = long.Parse(inputNumAsText);
                sb.AppendLine("* long");
            }
            catch (Exception)
            {

                Console.WriteLine($"{inputNumAsText} can't fit in any type");
                return;
            }
                       
            Console.WriteLine($"{inputNumAsText} can fit in:");
            Console.WriteLine(sb.ToString());
        }
    }
}