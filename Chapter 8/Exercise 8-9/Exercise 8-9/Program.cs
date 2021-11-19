using System;
using static System.Console;

namespace Exercise_8_9
{
	class Movie
	{
		static void Main(string[] args)
		{
			Random minutes = new Random();

			//Write("Enter you movie name: ");
			//string title = ReadLine();

			//DisplayMovie(title, minutes.Next(60, 300));

			DisplayMovie("The temple of Light", minutes.Next(60, 300));
			DisplayMovie("Avenger (End Game)", minutes.Next(60, 300));
		}

		public static void DisplayMovie(string title, int minutes)
		{
			WriteLine($"The movie {title} has a runing time of {minutes} minutes!");
		}
	}
}
