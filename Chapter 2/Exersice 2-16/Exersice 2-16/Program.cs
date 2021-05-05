/*
Create an enumeration named Month that holds values for the months of the year,
starting with JANUARY equal to 1. Write a program named MonthNames that prompts
the user for a month integer. Convert the user’s entry to a Month value, and display it.
 */



using System;

namespace Exersice_2_16
{
    class MonthNames
    {
        enum Month
        { January = 1, February, March, April, May, June, July, August, Septemper, October, November, December }

        static void Main(string[] args)
        {
            Console.Write("Enter number of months: ");
            int input = int.Parse(Console.ReadLine());
            Month selectMonth;
            selectMonth = ((Month)input);
            int valueMonth = (int)selectMonth;
            Console.WriteLine("Value of Month is: {0}", valueMonth);
            Console.WriteLine("The month you entered is {0}", selectMonth);
            Console.Read();
        }
    }
}
