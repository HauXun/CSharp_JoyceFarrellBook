/*
In Chapter 4, you created a program that generates a random number, allows a user to
guess it, and displays a message indicating whether the guess is too low, too high, or
correct. Now, create a modified program called GuessingGame2 in which the user
can continue to enter values until the correct guess is made. After the user guesses
correctly, display the number of guesses made.

Recall that you can generate a random number whose value is at least min and less than max using the
following statements:
Random ranNumber = new Random();
int randomNumber;
randomNumber = ranNumber.Next(min, max);
 */




using System;
using static System.Console;

namespace Exercise_5_14
{
    class GuessingGame2
    {
        static void Main(string[] args)
        {
            const int MIN = 1;
            const int MAX = 16;
            int randomNumber;
            int input = -1;
            int count = 0;

            Random numberGenerator = new Random();
            randomNumber = numberGenerator.Next(MIN, MAX);
            while (input != randomNumber)
            {
                Write("Guess a number ({0} - {1}): ", MIN, MAX - 1);
                input = int.Parse(ReadLine());
                count++;
                if (input == randomNumber)
                    WriteLine("\nCorrect! {0} guesses.", count);
            }
        }
    }
}
