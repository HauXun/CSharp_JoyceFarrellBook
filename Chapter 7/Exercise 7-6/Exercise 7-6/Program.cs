/*
Create an application for a library and name it FineForOverdueBooks. The Main()
method asks the user to input the number of books checked out and the number of
days they are overdue. Pass those values to a method that displays the library fine,
which is 10 cents per book per day for the first seven days a book is overdue, then
20 cents per book per day for each additional day
 */



using System;
using System.Globalization;
using static System.Console;

namespace Exercise_7_6
{
	class FineForOverdueBooks
	{
		public static void Main(string[] args)
		{
			int numberOfBooks = 0;
			int dayOfBooks = 0;
			Write("Enter number of books that are overdue >> ");
			dayOfBooks = int.Parse(ReadLine());
			Write("Enter number of days that the {0} books are overdue >> ", dayOfBooks);
			dayOfBooks = int.Parse(ReadLine());
			DisplayFine(numberOfBooks, dayOfBooks);
		}

		public static void DisplayFine(int numberOfBooks, int dayOfBooks)
		{
			const double first7Days = 0.10;
			const double next7day = 0.20;
			const int increasesDays = 7;
			double fineLibrary;
			if (dayOfBooks <= increasesDays)
				fineLibrary = dayOfBooks * numberOfBooks * first7Days;
			else
				fineLibrary = numberOfBooks * first7Days * increasesDays
					+ dayOfBooks * next7day * (dayOfBooks - increasesDays);
			WriteLine($"The fine for {numberOfBooks} book(s) for {dayOfBooks} day(s) is {fineLibrary.ToString("c", CultureInfo.GetCultureInfo("en-US"))}");
		}
	}
}
