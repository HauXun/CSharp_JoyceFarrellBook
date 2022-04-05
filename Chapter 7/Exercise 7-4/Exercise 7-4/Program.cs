/*
Create an application named ConvertMilesToKilometers whose Main() method
prompts a user for a number of miles, passes the value to a method that converts
the value to kilometers, and then returns the value to the Main() method where it is
displayed. A mile is 1.60934 kilometers.
 */




using System;
using static System.Console;

namespace Exercise_7_4
{
	class ConvertDistance
	{
		public static double ConvertMilesToKilometers(double miles)
		{
			// Multiply by this constant and return the result.

			return miles * 1.609344;
		}

		public static double ConvertKilometersToMiles(double kilometers)
		{
			// Multiply by this constant.

			return kilometers * 0.621371192;
		}
	}

	class ConvertMilesToKilometers
	{
		static void Main()
		{
			// Convert miles to kilometers.

			double miles1 = 200;
			double kilometers1 = ConvertDistance.ConvertMilesToKilometers(200);
			WriteLine("{0} Miles = {1} Kilometers", miles1, kilometers1);

			// Convert kilometers to miles.

			double kilometers2 = 321.9;
			double miles2 = ConvertDistance.ConvertKilometersToMiles(321.9);
			WriteLine("{0} Kilometers = {1} Miles", kilometers2, miles2);

			// Convert kilometers to miles (again).

			double kilometers3 = 500;
			double miles3 = ConvertDistance.ConvertKilometersToMiles(500);
			WriteLine("{0} Kilometers = {1} Miles", kilometers3, miles3);

			// Convert miles to kilometers (again).

			double miles4 = 310.7;
			double kilometers4 = ConvertDistance.ConvertMilesToKilometers(310.7);
			WriteLine("{0} Miles = {1} Kilometers", miles4, kilometers4);
		}
	}
}
