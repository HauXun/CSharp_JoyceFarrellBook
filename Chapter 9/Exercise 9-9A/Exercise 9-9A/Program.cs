/*
Create a program named RelativesList that declares an array of at least 12 relative
objects and prompts the user to enter data about them. The Relative class
includes auto-implemented properties for the Relative’s name, relationship to
you (for example, aunt), and three integers that together represent the Relative’s
birthday—month, day, and year. Display the Relative objects in alphabetical
order by first name.
 */




using System;
using static System.Console;

namespace Exercise_9_9A
{
	class RelativesList
	{
		static void Main(string[] args)
		{
			Relative[] relativeArray = new Relative[12];
			int m;
			for (int i = 0; i < relativeArray.Length; i++)
			{
				relativeArray[i] = new Relative();
				Write("Enter your relative's name >> ");
				relativeArray[i].Name = ReadLine();
				Write("Enter {0}'s relationship to you >> ", relativeArray[i].Name);
				relativeArray[i].relationShip = ReadLine();
				Write("Enter your relative's birth month >> ");
				int.TryParse(ReadLine(), out m);
				relativeArray[i].month = m;
				Write("Enter your relative's birth day >> ");
				int.TryParse(ReadLine(), out m);
				relativeArray[i].day = m;
				Write("Enter your relative's birth year >> ");
				int.TryParse(ReadLine(), out m);
				relativeArray[i].year = m;
			}

			Array.Sort(relativeArray);
			WriteLine("".PadRight(20, '-') + "Sorted Relatives".PadRight(20, '-'));
			for (int i = 0; i < relativeArray.Length; i++)
			{
				WriteLine("{0, -15}{1, -15}{2}/{3}/{4}", 
					relativeArray[i].Name, relativeArray[i].relationShip, 
					relativeArray[i].month, relativeArray[i].day, relativeArray[i].year);
			}
		}
	}
}
