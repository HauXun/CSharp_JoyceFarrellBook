/*
Add an operator*() method to the Fraction class created in Exercise 11a so
that it correctly multiplies two Fractions. The result should be in proper, reduced
format. Demonstrate that the method works correctly in a program named
FractionDemo2.
*/




using System;
using static System.Console;

namespace Exercise_9_11B
{
	class FractionDemo2
	{
		static void Main(string[] args)
		{
			Fraction f1 = new Fraction(1, 4);
			Fraction f2 = new Fraction(1, 8);
			Fraction f3 = new Fraction(2, 1, 2);
			Fraction f4 = new Fraction();
			Fraction answer = new Fraction();

			answer = f1 * f2;
			WriteLine("{0} * {1} = {2}", f1.FracString(), f2.FracString(), answer.FracString());
			answer = f1 * f3;
			WriteLine("{0} * {1} = {2}", f1.FracString(), f3.FracString(), answer.FracString());
			answer = f2 * f3;
			WriteLine("{0} * {1} = {2}", f2.FracString(), f3.FracString(), answer.FracString());
			answer = f1 + f2;
			WriteLine("{0} * {1} = {2}", f1.FracString(), f2.FracString(), answer.FracString());
			answer = f1 + f3;
			WriteLine("{0} * {1} = {2}", f1.FracString(), f3.FracString(), answer.FracString());
			answer = f2 + f3;
			WriteLine("{0} * {1} = {2}", f2.FracString(), f3.FracString(), answer.FracString());
		}

		static void GetData(Fraction f)
		{
			int temp;
			Write("Enter whole number portion of fraction >> ");
			int.TryParse(ReadLine(), out temp);
			f.WholeNumber = temp;
			Write("Enter numerator >> ");
			int.TryParse(ReadLine(), out temp);
			f.Numerator = temp;
			Write("Enter denominator >> ");
			int.TryParse(ReadLine(), out temp);
			f.Denominator = temp;
			WriteLine("\n".PadRight(5, '-') + "Enter complete" + "".PadRight(5, '-'));
		}
	}
}
