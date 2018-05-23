using System;

namespace Ex02m_Pr06_DNASequences
{
    class Ex02m_Pr06_DNASequences
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            // A -> 1; C -> 2; G -> 3; T -> 4
            int counter = 0;

            for (char i = 'A'; i <= 'T'; i++)
            {
                if (IsEqialToLetter(i))
                {
                    continue;
                }
                for (char j = 'A'; j <= 'T'; j++)
                {
                    if (IsEqialToLetter(j))
                    {
                        continue;
                    }
                    for (char k = 'A'; k <= 'T'; k++)
                    {
                        if (IsEqialToLetter(k))
                        {
                            continue;
                        }
                        counter++;
                        string tempDNA = "" + i.ToString() + j.ToString() + k.ToString();

                        int result = 0;

                        for (int l = 0; l < tempDNA.Length; l++)
                        {
                            string a = tempDNA[l].ToString();
                            if (a == "A")
                            {
                                result += 1;
                            }
                            else if (a == "C")
                            {
                                result += 2;
                            }
                            else if(a == "G")
                            {
                                result += 3;
                            }
                            else if(a == "T")
                            {
                                result += 4;
                            }

                        }

                        if (num <= result)
                        {
                            Console.Write($"O{i}{j}{k}O ");
                        }
                        else
                        {
                            Console.Write($"X{i}{j}{k}X ");
                        }

                        if (counter ==  4)
                        {
                            Console.WriteLine();
                            counter = 0;
                        }
                    }
                }
            }
        }

        private static bool IsEqialToLetter(char i)
        {
            return i == 'A' == false && i == 'C' == false
                                && i == 'G' == false && i == 'T' == false;
        }
    }
}
