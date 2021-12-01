/*
Write a program named SortWords that includes a method that accepts any number
of words and sorts them in alphabetical order. Demonstrate that the program works
correctly when the method is called with one, two, five, and ten words.
 */




using System;
using static System.Console;

namespace Exercise_8_8
{
	class Sort
	{
		public static void Sort_Display(params string[] words)
		{
			Write("Words:\n");
			foreach (var item in words)
			{
				Write($"{item} => ");
			}
			WriteLine("\n");

			Array.Sort(words);
			Write("\nAfter being sorted...\n");
			foreach (var item in words)
			{
				Write($"{item} => ");
			}
			WriteLine("\n");
		}
	}
	class SortWords
	{
		static void Main(string[] args)
		{
			string[] words = { "program", "reverse", "happy", "heart", "zero", "project", "head", "monster" };
			Sort.Sort_Display(words);
			Sort.Sort_Display("a", "W", "b", "S", "g", "h");
			Sort.Sort_Display("how", "to", "exeption");
			Sort.Sort_Display("How", "you", "like", "that");
			Sort.Sort_Display("SuCk");
		}
	}
}
