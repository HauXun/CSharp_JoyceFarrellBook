/*
Create a program named FindSquareRoot that finds the square root of a user’s input
value. The Math class contains a static method named Sqrt() that accepts a double
and returns the parameter’s square root. If the user’s entry cannot be converted to a
double, display an appropriate message, and set the square root value to 0. Otherwise,
test the input number’s value. If it is negative, throw a new ApplicationException
to which you pass the message “Number can’t be negative.” and again set sqrt to 0. If
the input value is a double and not negative, pass it to the Math.Sqrt() method, and
display the returned value.
 */





using System;
using static System.Console;

namespace Exercise_11_3
{
	class Program
	{
		static void Main(string[] args)
		{
			double number, sqrt;
			try
			{
				Write("Enter a number >> ");
				if (!double.TryParse(ReadLine(), out number))
					WriteLine("Enter a number is not a double");
				if (number < 0)
					throw (new ApplicationException("Number can't be negative number."));
				sqrt = Math.Sqrt(number);
			}
			catch (ApplicationException e)
			{
				WriteLine("Error: {0}", e.Message);
				sqrt = 0;
			}
			WriteLine("Square root is {0}", sqrt);
		}
	}
}
