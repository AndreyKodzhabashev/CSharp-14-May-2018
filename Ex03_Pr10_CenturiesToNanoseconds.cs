using System;

namespace Ex03_Pr10_CenturiesToNanoseconds
{
    class Ex03_Pr10_CenturiesToNanoseconds

    {
        static void Main()
        {
            int centuries = int.Parse(Console.ReadLine());

            int centToYears = centuries * 100;
            long days = (long)(centToYears * 365.2422);
            decimal hours = days * 24;
            decimal minutes = hours * 60;
            decimal seconds = minutes * 60;
            string milisec = "" + seconds + "000";
            string microsec = milisec + "000";
            string nanosec = microsec + "000";

            Console.WriteLine($"{centuries} centuries = {centToYears} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milisec} milliseconds = {microsec} microseconds = {nanosec} nanoseconds");
        }
    }
}