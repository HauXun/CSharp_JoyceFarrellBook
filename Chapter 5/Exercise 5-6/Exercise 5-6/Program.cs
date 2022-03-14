/*
Write an application named DisplayMultiplicationTable that displays a table of the
products of every combination of two integers from 1 through 10.
 */



using System;
using static System.Console;

namespace Exercise_5_6
{
	class DisplayMultiplicationTable
	{
		static void Main(string[] args)
		{
			int first, second;
			const int LIMIT = 10;
			Write("     ");
			for (first = 1; first <= LIMIT; first++)
				Write("{0, 5}", first);
			WriteLine();
			WriteLine("".PadRight(55, '-'));
			WriteLine();
			for (first = 1; first <= LIMIT; first++)
			{
				Write("{0, 5}", first);
				for (second = 1; second <= LIMIT; second++)
					Write("{0, 5}", first * second);
				WriteLine();
			}
		}
	}
}
