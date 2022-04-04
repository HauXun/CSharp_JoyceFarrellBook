/*
Create a program named PaintingEstimate whose Main() method prompts a user
for length and width of a room in feet. Create a method that accepts the values and
then computes the cost of painting the room, assuming the room is rectangular and
has four full walls and 9-foot ceilings. The price of the job is $6 per square foot. Return
the price to the Main() method, and display it.
 */




using System;
using static System.Console;

namespace Exercise_7_3
{
	class PaintingEstimate
	{
		static void Main(string[] args)
		{
			Write("Enter the length of the room (in feet): ");
			int length = int.Parse(ReadLine());
			Write("Enter the width of the room (in feet): ");
			int width = int.Parse(ReadLine());
			ComputeCost(length, width);
		}

		public static void ComputeCost(int length, int width)

		{
			double cost = ((length * 9 * 2) + (width * 9 * 2)) * 6;
			WriteLine($"\nThe cost of painting your room is {cost.ToString("c")}$");
		}
	}
}
