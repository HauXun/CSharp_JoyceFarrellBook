/*
Write a FractionDemo program that instantiates several Fraction objects and
demonstrates that their methods work correctly. Create a Fraction class with
fields that hold a whole number, a numerator, and a denominator. In addition:
• Create properties for each field. The set accessor for the denominator should
not allow a 0 value; the value defaults to 1.
• Add three constructors. One takes three parameters for a whole number,
numerator, and denominator. Another accepts two parameters for the
numerator and denominator; when this constructor is used, the whole number
value is 0. The last constructor is parameterless; it sets the whole number and
numerator to 0 and the denominator to 1. (After construction, Fractions do
not have to be reduced to proper form. For example, even though 3/9 could be
reduced to 1/3, your constructors do not have to perform this task.)
• Add a Reduce() method that reduces a Fraction if it is in improper form. For
example, 2/4 should be reduced to 1/2.
• Add an operator+() method that adds two Fractions. To add two fractions,
first eliminate any whole number part of the value. For example, 2 1/4 becomes
9/4 and 1 3/5 becomes 8/5. Find a common denominator and convert the
fractions to it. For example, when adding 9/4 and 8/5, you can convert them to
45/20 and 32/20. Then you can add the numerators, giving 77/20. Finally, call
the Reduce() method to reduce the result, restoring any whole number value so
the fractional part of the number is less than 1. For example, 77/20 becomes 3
17/20.
• Include a function that returns a string that contains a Fraction in the usual
display format—the whole number, a space, the numerator, a slash (/), and a
denominator. When the whole number is 0, just the Fraction part of the value
should be displayed (for example, 1/2 instead of 0 1/2). If the numerator is 0, just
the whole number should be displayed (for example, 2 instead of 2 0/3).
 */




using System;
using static System.Console;

namespace Exercise_9_11A
{
	class FractionDemo
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
