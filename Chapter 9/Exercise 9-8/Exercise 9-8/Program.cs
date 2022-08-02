/*
Create a program named ConferencesDemo for a hotel that hosts business
conferences. Allows a user to enter data about five Conference objects and then
displays them in order of attendance from smallest to largest. The Conference
class contains fields for the Conference group name, starting date (as a string),
and number of attendees. Include properties for each field. Also, include an
IComparable.CompareTo() method so that Conference objects can be sorted.
 */




using System;
using static System.Console;

namespace Exercise_9_8
{
	class ConferencesDemo
	{
		static void Main(string[] args)
		{
			Conference[] cfrArray = new Conference[5];
			for (int i = 0; i < cfrArray.Length; i++)
			{
				cfrArray[i] = new Conference();
				Write("Enter conference group name >> ");
				cfrArray[i].Group = ReadLine();
				Write("Enter conference starting date >> ");
				cfrArray[i].Date = ReadLine();
				Write("Enter attendees >> ");
				cfrArray[i].Attendees = int.Parse(ReadLine());
			}

			WriteLine("\n");

			Array.Sort(cfrArray);
			WriteLine("".PadRight(20, '-') + "Sorted Conferences".PadRight(20, '-'));
			for (int i = 0; i < cfrArray.Length; i++)
			{
				WriteLine("{0} conference starts on {1} and has {2} attendees", cfrArray[i].Group, cfrArray[i].Date, cfrArray[i].Attendees);
			}
		}
	}
}
