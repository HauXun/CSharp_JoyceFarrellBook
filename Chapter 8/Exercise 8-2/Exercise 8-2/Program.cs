/*
Create a program named IntegerFacts whose Main() method declares an array of
10 integers. Call a method to interactively fill the array with any number of values up
to 10 or until a sentinel value is entered. If an entry is not an integer, reprompt the
user. Call a second method that accepts out parameters for the highest value in the
array, lowest value in the array, sum of the values in the array, and arithmetic average.
In the Main() method, display all the statistics.
 */




using System;
using static System.Console;

namespace Exercise_8_2
{
	class TryFill
	{
		public int[] a = new int[10];
		public int arraylength;
		public double avg;
		public int sum;
		public int high;
		public int low;

		public int FillArray(int[] array)
		{
			const int QUIT = 999;
			int input = 0;
			int n = 0;
			Write("Please enter an integer or enter {0} to quit program >> ", QUIT);
			while (n < array.Length && input != QUIT)
			{
				if (int.TryParse(ReadLine(), out input))
				{
					if (input != QUIT)
					{
						array[n] = input;
						n++;
						Write("Please enter an integer or enter {0} to quit program >> ", QUIT);
					}
				}
				else
					Write("Invalid entry - try again >> ");
			}
			return n;
		}


		public void Statistics(int[] array, int aLength, out int high, out int low, out int sum, out double avg)
		{
			sum = 0;
			avg = 0;
			high = array[0];
			low = array[0];

			for (int i = 0; i < aLength; i++)
			{
				sum += array[i];
				if (array[i] > high)
					high = array[i];
				if (array[i] < low)
					low = array[i];
			}
			if (aLength != 0)
				avg = sum * 1.0 / aLength;
		}
	}
	class IntegerFacts
	{
		static void Main(string[] args)
		{
			TryFill any = new TryFill();

			any.arraylength = any.FillArray(any.a);
			any.Statistics(any.a, any.arraylength, out any.high, out any.low, out any.sum, out any.avg);

			WriteLine("\nCurrent array...\n");
			for (int i = 0; i < any.arraylength; i++)
				Write("{0, 6}", any.a[i]);

			WriteLine("\n\nThe array has {0} values", any.arraylength);
			WriteLine("The highest value is {0}", any.high);
			WriteLine("The lowest value is {0}", any.low);
			WriteLine("The sum of the values is {0}", any.sum);
			WriteLine("The average is {0}", any.avg);
		}
	}
}
