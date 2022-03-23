/*
Modify the GuessingGame2 program to create a program called GuessingGame3
in which the player is criticized for making a “dumb” guess. For example, if the player
guesses that the random number is 4 and is told that the guess is too low, and then the
player subsequently makes a guess lower than 4, display a message that the user should
have known not to make such a low guess.
 */



using System;
using static System.Console;

namespace Exercise_5_15
{
    class GuessingGame3
    {
        static void Main(string[] args)
        {
            const int MIN = 1;
            const int MAX = 16;
            int randomNumber;
            Nullable<int> preInput = null;
            int input = -1;
            int guesses = 1;

            Random numberGenerator = new Random();
            randomNumber = numberGenerator.Next(MIN, MAX);
            while (input != randomNumber)
            {
                Write("Guess a number ({0} - {1}): ", MIN, MAX - 1);
                input = int.Parse(ReadLine());
                if (input == randomNumber)
                {
                    WriteLine("\nCorrect! {0} guesses.", guesses);
                }
                else if (input < randomNumber)
                {
                    WriteLine("Too low");
                    guesses++;
                    if (preInput != null && input < preInput && preInput < randomNumber)
                        WriteLine("You are so stupid, don't guess so low.");
                }
                else
                {
                    WriteLine("Too high");
                    guesses++;
                    if (preInput != null && input > preInput && preInput > randomNumber)
                        WriteLine("You are so stupid, don't guess so higher.");
                }
                preInput = input;
            }
        }
    }
}
