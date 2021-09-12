/*
Write a program named GuessingGame that generates a random number between
1 and 10. (In other words, in the example above, min is 1 and max is 11.) Ask a user to
guess the random number, then display the random number and a message indicating
whether the user’s guess was too high, too low, or correct.
 */



using System;

namespace Exercise_4_7
{
    class GuessingGame
    {
        static void Main(string[] args)
        {
            Random newRamdom = new Random();
            int ramdom = newRamdom.Next(0, 100);
            int input;
            do
            {
                Console.Write("Enter your values to guess ramdom numbers: ");
                input = int.Parse(Console.ReadLine());
                if (input > ramdom)
                    Console.WriteLine("Your predicted value is already larger");
                else if (input < ramdom)
                    Console.WriteLine("Your predicted value is already smaller");
                else
                    Console.WriteLine("Your prediction value is correct");
            } while (input != ramdom);
            Console.ReadLine();
        }
    }
}
