/*
Write an application named MultiplicationTable that prompts the user for an integer
value, for example 7. Then display the product of every integer from 1 through 10
when multiplied by the entered value. For example, the first three lines of the table
might read 1 3 7 5 7, 2 3 7 5 14, and 3 3 7 5 21.
 */



using System;
using static System.Console;

namespace Exercise_5_7
{
    class MultiplicationTable
    {
        static void Main(string[] args)
        {
            WriteLine("The table combines two integer from 1 to 10\n\n");
            Write("Enter a number: ");
            var input = Convert.ToDouble(ReadLine());
            WriteLine("\n");

            double answer;
            int loop = 1;
            while (loop <= 10)
            {
                answer = input * loop;
                Write("{1} X {0} = {2}\n", input, loop, answer);
                loop++;
            }
        }
    }
}
