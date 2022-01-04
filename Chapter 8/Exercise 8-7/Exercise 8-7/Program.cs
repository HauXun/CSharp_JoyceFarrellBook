/*
 Write a program named Averages that includes a method that accepts any number of
numeric parameters, displays them, and displays their average. Demonstrate that the
method works correctly when passed one, two, or three numbers, or an array of numbers.
 */




using System;
using static System.Console;

namespace Exercise_8_7
{
	class Calculator
	{
		public static double Average(params double[] numbers)
		{
			double total = 0;
			double avg;

			Write("Numbers ");
			foreach (var item in numbers)
			{
				Write($"{item} ");
				total += item;
			}
			return (numbers.Length == 0) ? 0 : total / numbers.Length;
		}
	}
	class Averages
	{
		static void Main(string[] args)
		{
			double[] array = { 1, 9, 0, 0, 9, 6, 6, 9 };
			WriteLine($" Has average is {Calculator.Average(array)}");
			WriteLine($" Has average is {Calculator.Average(2, 0, 1, 1, 3, 7, 9)}");
			WriteLine($" Has average is {Calculator.Average(113, 115, 114, 110)}");
			WriteLine($" Has average is {Calculator.Average(191)}");
			WriteLine($" Has average is {Calculator.Average()}");
		}
	}
}
