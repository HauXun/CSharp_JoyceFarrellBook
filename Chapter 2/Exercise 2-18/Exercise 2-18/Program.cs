/*
Pig Latin is a nonsense language. To create a word in pig Latin, you remove the first
letter and then add the first letter and “ay” at the end of the word. For example, “dog”
becomes “ogday” and “cat” becomes “atcay.” Write a program named PigLatin that
allows the user to enter a word and displays the pig Latin version.
 */



using System;

namespace Exercise_2_18
{
    class PigLatin
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your word to convert to Latin: ");
            string word = Console.ReadLine();
            int length = word.Length;
            string defaultWord = "ay";
            string firstWord = word.Substring(0, 1);
            string remainingWord = word.Substring(1, length - 1);
            string standardizedString = remainingWord + firstWord + defaultWord;
            Console.WriteLine("Latin version of this word is {0}", standardizedString);
            Console.Read();
        }
    }
}
