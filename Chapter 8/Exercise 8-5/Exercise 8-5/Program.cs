/*
Create a program named TipCalculation that includes two overloaded methods—one
that accepts a meal price and a tip as doubles (for example, 30.00 and 0.20, where
0.20 represents a 20 percent tip), and one that accepts a meal price as a double and
a tip amount as an integer (for example, 30.00 and 5, where 5 represents a $5 tip).
Each method displays the meal price, the tip as a percentage of the meal price, the
tip in dollars, and the total of the meal plus the tip. Include a Main() method that
demonstrates each method.
 */



using System;
using System.Globalization;
using static System.Console;

namespace Exercise_8_5
{
	class Calculation
	{
		public void DisplayTipInfo(double price, double dblTipRate)
		{
			double intTipDollars = price * dblTipRate;
			double total = price + intTipDollars;
			WriteLine("\nMeal price: {0}. Tip percent: {1}", price.ToString("C", CultureInfo.GetCultureInfo("en-US")), dblTipRate.ToString("F2"));
			WriteLine("Tip in dollars: {0}. Total bill: {1}", intTipDollars.ToString("C", CultureInfo.GetCultureInfo("en-US")), total.ToString("C", CultureInfo.GetCultureInfo("en-US")));
		}

		public void DisplayTipInfo(double price, int intTipDollars)
		{
			double tipRate = intTipDollars / price;
			double total = price + intTipDollars;
			WriteLine("\nMeal price: {0}. Tip percent: {1}", price.ToString("C", CultureInfo.GetCultureInfo("en-US")), tipRate.ToString("F2"));
			WriteLine("Tip in dollars: {0}. Total bill: {1}", intTipDollars.ToString("C", CultureInfo.GetCultureInfo("en-US")), total.ToString("C", CultureInfo.GetCultureInfo("en-US")));
		}
	}
	class TipCalculation
	{
		static void Main(string[] args)
		{
			Calculation a = new Calculation();
			const double price = 30.00;
			const double dblTipRate = 0.20;
			const int intTipDollars = 5;

			WriteLine("Tip rate 20% per meal...");
			a.DisplayTipInfo(price, dblTipRate);
			WriteLine("\n\nTip rate {0}$ per meal...", intTipDollars);
			a.DisplayTipInfo(price, intTipDollars);
		}

	}
}
