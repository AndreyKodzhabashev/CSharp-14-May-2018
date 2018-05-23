using System;
using System.Text;
namespace Ex02m_Pr08_SMSTyping
{
    class Ex02m_Pr08_SMSTyping
    {
        static void Main()
        {
            StringBuilder sms = new StringBuilder();

            int counChars = int.Parse(Console.ReadLine());

            string message = String.Empty;

            for (int i = 0; i < counChars; i++)
            {
                int temp = int.Parse(Console.ReadLine());

                switch (temp)
                {
                    case 2:
                        sms.Append("a");
                        break;
                    case 22:
                        sms.Append("b");
                        break;
                    case 222:
                        sms.Append("c");
                        break;
                            case 3:
                        sms.Append("d");
                        break;
                    case 33:
                        sms.Append("e");
                        break;
                    case 333:
                        sms.Append("f");
                        break;
                    case 4:
                        sms.Append("g");
                        break;
                    case 44:
                        sms.Append("h");
                        break;
                    case 444:
                        sms.Append("i");
                        break;
                    case 5:
                        sms.Append("j");
                        break;
                    case 55:
                        sms.Append("k");
                        break;
                    case 555:
                        sms.Append("l");
                        break;
                    case 6:
                        sms.Append("m");
                        break;
                    case 66:
                        sms.Append("n");
                        break;
                    case 666:
                        sms.Append("o");
                        break;
                    case 7:
                        sms.Append("p");
                        break;
                    case 77:
                        sms.Append("q");
                        break;
                    case 777:
                        sms.Append("r");
                        break;
                    case 7777:
                        sms.Append("s");
                        break;
                    case 8:
                        sms.Append("t");
                        break;
                    case 88:
                        sms.Append("u");
                        break;
                    case 888:
                        sms.Append("v");
                        break;
                    case 9:
                        sms.Append("w");
                        break;
                    case 99:
                        sms.Append("x");
                        break;
                    case 999:
                        sms.Append("y");
                        break;
                    case 9999:
                        sms.Append("z");
                        break;
                    case 0:
                        sms.Append(" ");
                        break;
                }
            }
            Console.WriteLine(sms.ToString());
        }
    }
}
