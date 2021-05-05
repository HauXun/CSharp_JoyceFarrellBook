/*
Write a program named HoursAndMinutes that declares a minutes variable to
represent minutes worked on a job, and assign a value to it. Display the value in hours
and minutes. For example, 197 minutes becomes 3 hours and 17 minutes.
 */



using System;

namespace Exercise_2_10
{
    class HoursAndMinutes
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your total time: ");
            int totalTime = int.Parse(Console.ReadLine());

            int hours = totalTime / 60;
            int minutes = totalTime % 60;

            Console.WriteLine("The value in hours and minutes: {0} hours + {1} minutes", hours, minutes);
            Console.ReadLine();
        }
    }
}
