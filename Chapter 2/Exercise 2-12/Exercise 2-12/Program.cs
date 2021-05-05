/*
Modify the Eggs program to create a new one named EggsInteractive that prompts
the user for and accepts a number of eggs for each chicken.
 */



using System;

namespace Exercise_2_12
{
    class EggsInteractive
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first chickens eggs: ");
            int FirstEggs = int.Parse(Console.ReadLine());
            Console.Write("Enter second chickens eggs: ");
            int SecondEggs = int.Parse(Console.ReadLine());
            Console.Write("Enter third chickens eggs: ");
            int ThirdEggs = int.Parse(Console.ReadLine());
            Console.Write("Enter fourth chickens eggs: ");
            int ForthEggs = int.Parse(Console.ReadLine());

            int Total = FirstEggs + SecondEggs + ThirdEggs + ForthEggs;
            int Dozens = Total / 12;
            int Odd = Total % 12;
            Console.WriteLine("Total eggs is {0} dozen and {1} eggs.", Dozens, Odd);
            Console.ReadLine();
        }
    }
}
