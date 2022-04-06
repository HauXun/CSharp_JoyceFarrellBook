/*
Create an application for a library and name it FineForOverdueBooks. The Main()
method asks the user to input the number of books checked out and the number of
days they are overdue. Pass those values to a method that displays the library fine,
which is 10 cents per book per day for the first seven days a book is overdue, then
20 cents per book per day for each additional day
 */




using System;
using static System.Console;

namespace Exercise_7_5
{
	class FortuneTeller
	{
		static void Main()
		{
			string[] str = { "Meet a wonderful stranger", "Falls", "Found money", "Happy", "Sad", "Have a flight" };
			Random random = new Random();
			int index1 = random.Next(str.Length);
			int index2 = random.Next(str.Length);
			displayStrings(str[index1], str[index2]);
		}
		static void displayStrings(string s1, string s2)
		{
			WriteLine("First string: " + s1);
			WriteLine("Second string: " + s2);
		}
	}
}
