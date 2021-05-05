/*
Write a program named MakeChange that calculates and displays the conversion of
an entered number of dollars into currency denominations—twenties, tens, fives, and
ones. For example, $113 is 5 twenties, 1 ten, 0 fives, and 3 ones.
 */



using System;

namespace Exercise_2_13
{
    class MakeChange
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your dollars: $");
            int totalDollars = int.Parse(Console.ReadLine());
            int twenties = totalDollars / 20;
            int remainderTwenty = totalDollars % 20;
            int tens = remainderTwenty / 10;
            int remainderTen = totalDollars % 10;
            int fives = remainderTen / 5;
            int remainderFive = totalDollars % 5;
            int ones = remainderFive / 1;
            Console.WriteLine("\nSelection 1:");
            Console.WriteLine("Total Entered is $" + totalDollars);
            Console.WriteLine("Twenty Dollar Bills: " + twenties);
            Console.WriteLine("Ten Dollar Bills: " + tens);
            Console.WriteLine("Five Dollar Bills: " + fives);
            Console.WriteLine("One Dollar Bills: " + ones);


            int twenties2 = totalDollars / 20;
            int tens2 = totalDollars / 10;
            int fives2 = totalDollars / 5;
            int ones2 = totalDollars / 1;
            Console.WriteLine("\nSelection 2:");
            Console.WriteLine("Total Entered is $" + totalDollars);
            Console.WriteLine("Twenty Dollar Bills: " + twenties2);
            Console.WriteLine("Ten Dollar Bills: " + tens2);
            Console.WriteLine("Five Dollar Bills: " + fives2);
            Console.WriteLine("One Dollar Bills: " + ones2);
            Console.ReadLine();
        }
    }
}
