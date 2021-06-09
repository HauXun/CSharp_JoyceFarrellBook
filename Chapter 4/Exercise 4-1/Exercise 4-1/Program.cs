/*
Write a program named CheckCredit that prompts users to enter a purchase price
for an item. If the value entered is greater than a credit limit of $8,000, display an error
message; otherwise, display Approved.
 */



using System;

namespace Exercise_4_1
{
    class CheckCredit
    {
        static void Main(string[] args)
        {
            const double CreditCheck = 8000;
            Console.Write("Enter a purchase price for an item: ");
            int price = int.Parse(Console.ReadLine());
            if (price > CreditCheck)
                Console.WriteLine("Error Limited");
            else
                Console.WriteLine("Approved");
            Console.Read();
        }
    }
}
