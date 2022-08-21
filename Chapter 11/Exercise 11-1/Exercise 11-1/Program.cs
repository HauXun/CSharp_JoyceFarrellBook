/*
Write a program named SubscriptExceptionTest in which you declare an array
of 10 doubles and store values in the array. Write a try block in which you
place a loop that prompts the user for a subscript value and displays the value
stored in the corresponding array position. Create a catch block that catches any
IndexOutOfRangeException and displays an appropriate error message.
 */





using System;
using static System.Console;

namespace Exercise_11_1
{
	class SubscriptExceptionTest
	{
		static void Main(string[] args)
		{
			double[] array = { 20.3, 5.2, 8.32, 95.2, 3.2, 34.32, 21.95, 55.32 };
			int sub;
			const int QUIT = 99;
			Write("Enter a subscript value or {0} to quit >> ", QUIT);
			int.TryParse(ReadLine(), out sub);
			while (sub != QUIT)
			{
				try
				{
					WriteLine("The value is {0}", array[sub]);
				}
				catch (IndexOutOfRangeException e)
				{
					WriteLine(e.Message);
				}
				Write("Enter a subscript value or {0} to quit >> ", QUIT);
				int.TryParse(ReadLine(), out sub);
			}
		}
	}
}
