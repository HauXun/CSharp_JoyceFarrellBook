/*
a. Write a program named CheckMonth that prompts a user to enter a birth month.
If the value entered is greater than 12 or less than 1, display an error message;
otherwise, display the valid month with a message such as 3 is a valid month.

b. Write a program named CheckMonth2 that prompts a user to enter a birth month
and day. Display an error message if the month is invalid (not 1 through 12) or the day
is invalid for the month (for example, not between 1 and 31 for January or between 1
and 29 for February). If the month and day are valid, display them with a message.
 */



using System;

namespace Exercise_4_5
{
    class CheckMonth
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your birth month: ");
            int birthMonth = int.Parse(Console.ReadLine());

            if (birthMonth > 12 || birthMonth < 1)
                Console.WriteLine("Invalid! Please re-enter");
            else
                Console.WriteLine("{0} is a valid month", birthMonth);
            Console.ReadLine();
        }
    }

    class CheckMonth2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your date of birth: ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("Enter your birth month: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("\n\nEnter your year of birth (To calculate leap year): ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("\n\n\n");

            //Check year
            if (year >= 1900 && year <= 9999)
            {
                //Check month
                if (month >= 1 && month <= 12)
                {
                    //Check days
                    if ((day >= 1 && day <= 31) && (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12))
                        Console.WriteLine("Date and month is valid.\n");
                    else if ((day >= 1 && day <= 30) && (month == 4 || month == 6 || month == 9 || month == 11))
                        Console.WriteLine("Date and month is valid.\n");
                    else if ((day >= 1 && day <= 28) && (month == 2))
                        Console.WriteLine("Date and month is valid.\n");
                    else if (day == 29 && month == 2 && (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)))
                        Console.WriteLine("Date and month is valid.\n");
                    else
                        Console.WriteLine("Day is invalid and month is {0}.\n", month);
                }
                else
                {
                    Console.WriteLine("Month is not valid.\n");
                }
            }
            else
            {
                Console.WriteLine("Year is not valid.\n");
            }
            Console.Read();
        }
    }
}
