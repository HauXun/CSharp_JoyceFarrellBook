/*
Write an application named OddNums that displays all the odd numbers from 1
through 99.
 */



using System;
using static System.Console;

namespace Exercise_5_8
{
    class OddNums
    {
        static void Main(string[] args)
        {
            WriteLine("Odd numbers from 1 through 99.\n\n");

            for (int i = 1; i <= 99; i++)
                if (i % 2 != 0)
                    Write("{0, 5}", i);

            WriteLine("\n\n");
        }
    }
}
