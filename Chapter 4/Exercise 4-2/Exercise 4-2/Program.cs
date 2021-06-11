/*
Write a program named Twitter that accepts a user’s message and determines
whether it is short enough for a social networking service that does not accept
messages of more than 140 characters.
 */



using System;

namespace Exercise_4_2
{
    class Twitter
    {
        static void Main(string[] args)
        {
            const int MAX = 140;
            Console.Write("Enter a message to check: ");
            string messages = Console.ReadLine();
            if (messages.Length <= MAX)
                Console.WriteLine("Yes, it's short enough for Twitter");
            else
                Console.WriteLine("Sorry your messages was too long");
            Console.ReadLine();
        }
    }
}
