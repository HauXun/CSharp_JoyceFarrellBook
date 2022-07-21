/*
Write a program named CountVowelsModularized that passes a string to a method
that returns the number of vowels in the string.
 */



using System;
using static System.Console;

namespace Exercise_7_9
{
	class Vowels
	{
		public string userInput;
		public int vowelCount = 0;

		public int Vowel()
		{
			foreach (char letter in userInput)
				if ("aeiou".Contains(letter))
					vowelCount++;
			return vowelCount;
		}
	}

	class CountVowelsModularized
	{
		static void Main(string[] args)
		{
			Vowels a = new Vowels();
			Write("Please enter a word to see the amount of vowels it contains: ");
			a.userInput = ReadLine().ToLower();

			WriteLine($"\n{a.userInput} contains {a.Vowel()} vowels");
		}
	}
}
