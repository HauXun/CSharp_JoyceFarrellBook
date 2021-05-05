/*
Write a program named Eggs that declares four variables to hold the number of eggs
produced in a month by each of four chickens, and assign a value to each variable.
Sum the eggs, then display the total in dozens and eggs. For example, a total of 127
eggs is 10 dozen and 7 eggs.
 */



using System;

namespace Exercise_2_11
{
    class Eggs
    {
        static void Main(string[] args)
        {
            int FirstEggs = 12;
            int SecondEggs = 23;
            int ThirdEggs = 34;
            int ForthEggs = 45;

            int Total = FirstEggs + SecondEggs + ThirdEggs + ForthEggs;
            int Dozens = Total / 12;
            int Odd = Total % 12;
            Console.WriteLine("Total of {0} eggs is {1} dozen of eggs and {2} eggs.", Total, Dozens, Odd);
            Console.ReadLine();
        }
    }
}
