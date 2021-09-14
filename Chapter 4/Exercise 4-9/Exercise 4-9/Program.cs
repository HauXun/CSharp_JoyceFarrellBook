/*
Create a lottery game application named Lottery. Generate three random numbers,
each between 1 and 4. Allow the user to guess three numbers. Compare each of the
user’s guesses to the three random numbers, and display a message that includes the
user’s guess, the randomly determined three-digit number, and the amount of money
the user has won as follows:

Matching Numbers				Award ($)
Any one matching				10
Two matching					100
Three matching, not in order	1000
Three matching in exact order	10,000
No matches						0

Make certain that your application accommodates repeating digits. For example, if a
user guesses 1, 2, and 3, and the randomly generated digits are 1, 1, and 1, do not give
the user credit for three correct guesses—just one.
 */



using System;

namespace Exercise_4_9
{
    class Lottery
    {
        static void Main(string[] args)
        {
            int randomNumber;
            int randomNumber1;
            int randomNumber2;

            int Guess;

            int[] Guesses = new int[3];

            int Ramdom;
            int Amount = 0;
            int Count = 0;

            const int BALL = 3;
            const int MATCHONE = 10;
            const int MATCHTWO = 100;
            const int MATCHTHREE = 1000;
            const int MATCHFOUR = 10000;

            Random randomNumbers = new Random();

            int isContinue;

            do
            {
                randomNumber = randomNumbers.Next(1, 4);
                randomNumber1 = randomNumbers.Next(1, 4);
                randomNumber2 = randomNumbers.Next(1, 4);

                // Ramdom = Number1 + Number2 + Number3;

                for (Count = 0; Count < BALL; Count++)
                {
                    Console.Write("\nNo.{0} - Please enter your number: ", Count);
                    Guess = Convert.ToInt32(Console.ReadLine());

                    while (Guess < 1 || Guess > 4)
                    {
                        Console.WriteLine("You must enter numbers from 1 to 3, please re-enter: ");
                        Console.Write("\nNo.1 - Please enter your number: ");
                        Guess = int.Parse(Console.ReadLine());
                    }
                    Guesses[Count] = Guess;
                }

                if (Guesses[0] == randomNumber || Guesses[0] == randomNumber1 || Guesses[0] == randomNumber2)
                    Amount++;

                if (Guesses[1] == randomNumber || Guesses[1] == randomNumber1 || Guesses[1] == randomNumber2)
                    Amount++;

                if (Guesses[2] == randomNumber || Guesses[2] == randomNumber1 || Guesses[2] == randomNumber2)
                    Amount++;

                if (Guesses[0] == randomNumber && Guesses[1] == randomNumber1 && Guesses[2] == randomNumber2)
                    Amount++;

                if (Amount == 1)
                    Console.WriteLine("You guessed it right, you won ${0}!\n", MATCHONE);
                else if (Amount == 2)
                    Console.WriteLine("You guessed it right, you won ${0}!\n", MATCHTWO);
                else if (Amount == 3)
                    Console.WriteLine("You guessed it right, you won ${0}!\n", MATCHTHREE);
                else if (Amount == 4)
                    Console.WriteLine("Great! You already guessed all the numbers, you won ${0}!\n", MATCHFOUR);
                else
                    Console.WriteLine("I'm sorry, you didn't win.");

                Console.WriteLine("You have matched {0} numbers", Amount);
                Console.WriteLine("The numbers are: {0, 5} - {1, 5} - {2, 5}", randomNumber, randomNumber1, randomNumber2);

                Console.ReadKey();
                Console.WriteLine("Do you want to continue? Press 0 if you don't want to");
                isContinue = int.Parse(Console.ReadLine());
            } while (isContinue != 0);
            Console.ReadLine();
        }
    }
}
