/*
Account numbers sometimes contain a check digit that is the result of a mathematical
calculation. The inclusion of the digit in an account number helps ascertain whether
the number is a valid one. Write an application named CheckDigit that asks a user
to enter a four-digit account number and determines whether it is a valid number.
The number is valid if the fourth digit is the remainder when the number represented
by the first three digits of the four-digit number is divided by 7. For example, 7770 is
valid, because 0 is the remainder when 777 is divided by 7.

The next problems rely on the generation of a random number. You can
create a random number that is at least min but less than max using the
following statements:

Random ranNumberGenerator = new Random();
int randomNumber;
randomNumber = ranNumberGenerator.Next(min, max);
 */



using System;

namespace Exercise_4_6
{
    class CheckDigit
    {
        static void Main(string[] args)
        {
            const int DIGITS = 4;
            const int CHECK_FACTOR = 7;
            int accountBumbers;
            string accountNumberString;
            int firstThree;
            int lastOne;
            int remainder;

            Console.Write("Enter a four-digit account number: ");
            accountNumberString = Console.ReadLine();
            if (accountNumberString.Length != DIGITS)
                Console.WriteLine("Account number invalid - it must have {0} digits !", DIGITS);
            else
            {
                accountBumbers = int.Parse(accountNumberString);
                firstThree = accountBumbers / 10;
                lastOne = accountBumbers % 10;
                remainder = firstThree % CHECK_FACTOR;
                if (lastOne == remainder)
                    Console.WriteLine("{0} is a valid remainder: account number is valid", lastOne);
                else
                    Console.WriteLine("Invalid - last digit is not a good check digit.");
            }
            Console.ReadLine();
        }
    }
}
