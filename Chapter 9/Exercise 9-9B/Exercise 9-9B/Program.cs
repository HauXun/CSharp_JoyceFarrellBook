/*
Create a RelativesBirthday program that modifies the RelativesList program
so that after the alphabetical list is displayed, the program prompts the user for a
specific Relative’s name and the program returns the Relative’s relationship
and birthday. Display an appropriate message if the relative requested by the user is
not found.
 */




using System;
using static System.Console;

namespace Exercise_9_9B
{
	class RelativesList
	{
		static void Main(string[] args)
		{
			Relative[] relativeArray = new Relative[12];
			int m;
			string findRel;
			bool found = false;
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
			Write("Enter the name of the relative whose birthday you want to find >> ");
			findRel = ReadLine();
			for (int i = 0; i < relativeArray.Length; i++)
			{
				if (relativeArray[i].Name.Contains(findRel))
				{
					WriteLine("{0, -15}{1, -15}{2}/{3}/{4}",
						relativeArray[i].Name, relativeArray[i].relationShip,
						relativeArray[i].month, relativeArray[i].day, relativeArray[i].year);
					found = true;
				}
				if (!found)
					WriteLine("Sorry - No match for {0}", findRel);
			}
		}
	}
}
