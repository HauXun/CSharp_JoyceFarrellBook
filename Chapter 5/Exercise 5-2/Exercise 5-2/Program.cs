/*
Write an application named SumInts that allows the user to enter any number of
integers continuously until the user enters 999. Display the sum of the values entered,
not including 999.
 */



using System;

namespace Exercise_5_2
{
    class SumInts
    {
        static void Main(string[] args)
        {
            int inputAsInteger;

            string inputNumber;
            int sum = 0;
            int count = 0;

            const string LIMIT = "999";

            while (true)
            {
                count++;
                Console.WriteLine("You must enter an integer...");
                Console.Write("\nEnter the integer number {0} times: ", count);
                inputNumber = Console.ReadLine();

                if (inputNumber == LIMIT)
                {
                    break;
                }

                else if (int.TryParse(inputNumber, out inputAsInteger))
                {
                    sum += inputAsInteger;
                }

            }
            Console.WriteLine("\nLimit reached, stop...! ");
            Console.Write("Press any key to continue...");
            Console.ReadLine();
            Console.WriteLine("\nThe sum of the numbers entered except for the {0} number is {1}", LIMIT, sum);
            Console.ReadLine();
        }
    }
}
