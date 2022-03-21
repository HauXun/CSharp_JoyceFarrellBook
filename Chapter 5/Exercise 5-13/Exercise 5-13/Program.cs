/*
Write a program named CountVowels that accepts a phrase from the user and counts
the number of vowels in the phrase. For this exercise, count both uppercase and
lowercase vowels, but do not consider y to be a vowel.
 */



using System;
using static System.Console;

namespace Exercise_5_13
{
    class CountVowels
    {
        static void Main(string[] args)
        {
            string userInput;
            int vowelCount = 0;

            Write("Please enter a word to see the amount of vowels it contains: ");
            userInput = ReadLine().ToLower();

            foreach (char letter in userInput)
                if ("aeiou".Contains(letter))
                    vowelCount++;
            WriteLine("\n{0} contains {1} vowels", userInput, vowelCount);
        }
    }
}
