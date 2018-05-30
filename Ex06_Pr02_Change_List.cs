using System;
using System.Linq;
using System.Collections.Generic;

namespace Ex06_Pr02_Change_List
{
    class Ex06_Pr02_Change_List
    {
        static void Main(string[] args)
        {
            List<int> listNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                List<string> listCommand = Console.ReadLine()
                .Split(' ')
                .ToList();

                if (listCommand[0] == "Delete")
                {
                    int numberToDelete = int.Parse(listCommand[1]);

                    listNumbers.RemoveAll(x => x == numberToDelete);

                }
                else if (listCommand[0] == "Insert")
                {
                    int numberToInsert = int.Parse(listCommand[1]);
                    int positionForInsert = int.Parse(listCommand[2]);

                    listNumbers.Insert(positionForInsert, numberToInsert);
                }
                else if (listCommand[0].Equals("Odd") || listCommand[0].Equals("Even"))
                {
                    List<int> numsForPrint = new List<int>();

                    if (listCommand[0] == "Odd")
                    {
                       
                        foreach (var num in listNumbers)
                        {
                            if (num % 2 != 0)
                            {
                                numsForPrint.Add(num);
                            }
                        }
                    }
                    else
                    {
                       
                        foreach (var num in listNumbers)
                        {
                            if (num % 2 == 0)
                            {
                                numsForPrint.Add(num);
                            }
                        }
                    }
                    Console.WriteLine(string.Join(" ",numsForPrint));
                    return;
                }
            }
        }
    }
}
