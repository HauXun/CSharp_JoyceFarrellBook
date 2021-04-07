/*
Write a program named FractionDemo3 that includes an array of four
Fractions. Prompt the user for values for each. Display every possible
combination of addition results and every possible combination of multiplication
results for each Fraction pair (that is, each type will have 16 results).
 */




using System;
using static System.Console;

namespace Exercise_9_11C
{
	class FractionDemo3
	{
		static void Main(string[] args)
		{
			Fraction[] f = new Fraction[4];
			Fraction answer = new Fraction();
			for (int i = 0; i < f.Length; i++)
			{
				f[i] = new Fraction();
				GetData(f[i]);
			}
			WriteLine("".PadRight(10, '-') + "Addittion" + "".PadRight(10, '-'));
			for (int i = 0; i < f.Length; i++)
			{
				for (int j = 0; j < f.Length; j++)
				{
					answer = f[i] + f[j];
					WriteLine("{0} + {1} = {2}", f[i].FracString(), f[j].FracString(), answer.FracString());
				}
			}
			WriteLine("\n".PadRight(10, '-') + "Multiplication" + "".PadRight(10, '-'));
			for (int i = 0; i < f.Length; i++)
			{
				for (int j = 0; j < f.Length; j++)
				{
					answer = f[i] * f[j];
					WriteLine("{0} * {1} = {2}", f[i].FracString(), f[j].FracString(), answer.FracString());
				}
			}
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
