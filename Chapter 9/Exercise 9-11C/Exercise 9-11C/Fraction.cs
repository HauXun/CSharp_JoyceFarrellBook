using System;

namespace Exercise_9_11C
{
	class Fraction
	{
		int wholeNumber;
		int numerator;
		int denominator;

		public Fraction(int wholeNumber, int numerator, int denominator)
		{
			this.wholeNumber = wholeNumber;
			this.numerator = numerator;
			this.denominator = denominator;
		}

		public Fraction(int numerator, int denominator) : this(0, numerator, denominator)
		{

		}

		public Fraction() : this(0, 0, 1)
		{

		}

		public int WholeNumber
		{
			get => wholeNumber;
			set
			{
				wholeNumber = value;
			}
		}

		public int Numerator
		{
			get => numerator;
			set
			{
				numerator = value;
			}
		}

		public int Denominator
		{
			get => denominator;
			set
			{
				if (value != 0)
					denominator = value;
				else
					denominator = 1;
			}
		}

		public static Fraction operator +(Fraction f1, Fraction f2)
		{
			int num1 = (f1.wholeNumber * f1.denominator + f1.numerator) * f2.denominator;
			int num2 = (f2.wholeNumber * f2.denominator + f2.numerator) * f1.denominator;
			int num = num1 + num2;
			int denom = f1.denominator * f2.denominator;
			Fraction newFrac = new Fraction(num, denom);
			newFrac.Reduce();
			return newFrac;
		}

		public static Fraction operator *(Fraction f1, Fraction f2)
		{
			int num1 = (f1.wholeNumber * f1.denominator + f1.numerator);
			int num2 = (f2.wholeNumber * f2.denominator + f2.numerator);
			int num = num1 * num2;
			int denom = f1.denominator * f2.denominator;
			Fraction newFrac = new Fraction(num, denom);
			newFrac.Reduce();
			return newFrac;
		}

		public void Reduce()
		{
			int gcd;
			if (numerator >= denominator)
			{
				wholeNumber += numerator / denominator;
				numerator = numerator % denominator;
			}
			gcd = 1;
			for (int i = numerator; i > 0; i--)
			{
				if (numerator % i == 0 && denominator % i == 0)
				{
					gcd = i;
					i = 0;
				}
			}
			numerator /= gcd;
			denominator /= gcd;
		}

		public string FracString()
		{
			string fracString;
			if (wholeNumber == 0 && numerator == 0)
				fracString = "0";
			else if (wholeNumber == 0)
				fracString = numerator + "/" + denominator;
			else if (numerator == 0)
				fracString = "" + wholeNumber;
			else
				fracString = wholeNumber + " " + numerator + "/" + denominator;
			return fracString;
		}
	}
}
