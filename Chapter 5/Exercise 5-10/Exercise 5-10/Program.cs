/*
Write an application named Perfect that displays every perfect number from 1
through 10,000. A number is perfect if it equals the sum of all the smaller positive
integers that divide evenly into it. For example, 6 is perfect because 1, 2, and 3 divide
evenly into it and their sum is 6
 */



using System;
using static System.Console;

namespace Exercise_5_10
{
    class Perfect
    {
        static void Main(string[] args)
        {
            int sum;
            WriteLine("Here are all the perfect numbers from 1 to 10000\n\n");
            for (int n = 1; n <= 10000; n++)
            {
                sum = 0;
                for (int i = 1; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        sum += i;
                    }
                }
                if (sum == n)
                {
                    WriteLine("{0} is a perfect number", sum);
                }
            }
        }
    }
}
