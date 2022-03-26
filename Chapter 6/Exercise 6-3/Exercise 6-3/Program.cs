/*
Write a program named TemperaturesComparison that allows a user to input five
daily Fahrenheit temperatures that must range from −30 to 130; if a temperature
is out of range, require the user to reenter it. If no temperature is lower than any
previous one, display a message Getting warmer. If every temperature is lower than
the previous one, display a message Getting cooler. If the temperatures are not entered
in either ascending or descending order, display a message It’s a mixed bag. Finally,
display the temperatures in the order they were entered, and then display the average
of the temperatures.
 */



using System;
using static System.Console;

namespace Exercise_6_3
{
	class TemperaturesComparison
	{
		static void Main(string[] args)
		{
			int[] fahrenheit = new int[5];
			int sum = 0;
			WriteLine("This application calculates the average temperature of a provide dataset\n");
			for (int i = 0; i < 5; i++)
			{
				Write("{0} - Please enter the temperature: ", i + 1);
				fahrenheit[i] = int.Parse(ReadLine());
				while (fahrenheit[i] < -30 || fahrenheit[i] > 130)
				{
					if (fahrenheit[i] >= -30 && fahrenheit[i] <= 130)
						sum += fahrenheit[i];
					else
						WriteLine("Invalid input. Valid temperatures range from -30 through 130 Fahrenheit.");
					Write("{0} - Please enter the temperature: ", i + 1);
					fahrenheit[i] = int.Parse(ReadLine());
				}
			}
			int cool = 0;
			int warm = 0;
			double constant = fahrenheit[0];
			for (int i = 1; i < 5; i++)
			{
				if (constant > fahrenheit[i])
					cool++;
				else if (constant < fahrenheit[i])
					warm++;
			}
			if (warm == 4)
				WriteLine("Getting Warmer");
			else if (cool == 4)
				WriteLine("Getting coller");
			else
				WriteLine("It's a mixed bag");
			Read();
		}
	}
}
