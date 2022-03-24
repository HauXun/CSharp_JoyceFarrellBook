/*
Write a program named ArrayDemo that stores an array of 10 integers. Until the user
enters a sentinel value, allow the user four options: (1) to view the list in order from
the first to last position in the stored array, (2) to view the list in order from the last to
first position, (3) to choose a specific position to view, or (4) to quit the application.
 */



using System;
using System.Linq;
using static System.Console;

namespace Exercise_6_1
{
	class ArrayDemo
	{
		static void Main(string[] args)
		{
			Random randomNumber = new Random();
			int[] intArray = new int[10];
			for (int i = 0; i < intArray.Length; i++)
				intArray[i] = randomNumber.Next(10);

			WriteLine("Enter 1 of 4 options: ");
			WriteLine("1. To view the list in order from the first to last position in the stored array");
			WriteLine("2. To view the list in order from the last to first position");
			WriteLine("3. To choose a specific position to view");
			WriteLine("4. To quit the application");
			Write("\nEnter a number: ");

			int sentinel = int.Parse(ReadLine());

			do
			{
				for (int i = 0; i < 70; i++)
					Write("-");
				Write("\n");
				if (sentinel == 1)
				{
					WriteLine("View the list in order from the first to last position in the stored array");
					foreach (var item in intArray)
						Write("{0, 6}", item);
					break;
				}
				else if (sentinel == 2)
				{
					WriteLine("View the list in order from the last to first position");
					//Array.Reverse(intArray);
					WriteLine("\n Original array");
					foreach (var item in intArray)
						Write("{0, 6}", item);
					WriteLine("\n Array then");
					foreach (var item in intArray.Reverse()) // LinQ
						Write("{0, 6}", item);
					break;
				}
				else if (sentinel == 3)
				{
					Write("Specific location is: ");
					int index = int.Parse(ReadLine());
					WriteLine("Position {0} in the list has a value of {1}", index, intArray[index]);
					WriteLine("\n Original array");
					foreach (var item in intArray)
						Write("{0, 6}", item);
					break;
				}
			} while (sentinel != 4);
			ReadLine();
		}
	}
}
