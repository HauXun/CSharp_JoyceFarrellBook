/*
Write an application named Sum200 that sums the integers from 1 through 200.
Display the running total when the program is halfway complete (after the first 100
numbers), and at the end.
 */



using System;
using static System.Console;

namespace Exercise_5_9
{
    class Sum200
    {
        static void Main(string[] args)
        {
            WriteLine("Sums the integers from 1 through 200\n\n");

            int i = 1;
            int sum = 0;
            while (i <= 200)
            {
                sum += i;
                if (i <= 100)
                    // Display the running total when the program is halfway complete (after the first 100 numbers)
                    WriteLine("Sum is {0}", sum);
                ++i;
            }
            WriteLine("\n\nTotal after the end of the program is {0}", sum);
        }
    }
}
