using System;

namespace Ex01_Pr01_DebitCard
{
    class Ex01_Pr01_DebitCard
    {
        static void Main()
        {
            string firstNum = Console.ReadLine();
            string secondNum = Console.ReadLine();
            string thirdNum = Console.ReadLine();
            string fourthNum = Console.ReadLine();

            int reqDigitsFirstNum = 4 - firstNum.Length;
            int reqDigitsSecondNum = 4 - secondNum.Length;
            int reqDigitsThirdNum = 4 - thirdNum.Length;
            int reqDigitsFourthNum = 4 - fourthNum.Length;

            Console.WriteLine($"{new string('0', reqDigitsFirstNum)}{firstNum} {new string('0', reqDigitsSecondNum)}{secondNum} {new string('0', reqDigitsThirdNum)}{thirdNum} {new string('0', reqDigitsFourthNum)}{fourthNum}");
        }
    }
}
