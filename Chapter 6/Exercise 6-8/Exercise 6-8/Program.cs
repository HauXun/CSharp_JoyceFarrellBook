/*
Write a program for The Carefree Resort named ResortPrices that prompts the user
to enter the number of days for a resort stay. Then display the price per night and the
total price. Nightly rates are $200 for one or two nights; $180 for three or four nights;
$160 for five, six, or seven nights; and $145 for eight nights or more.
 */



using System;
using static System.Console;

namespace Exercise_6_8
{
	class ResortPrices
	{
		static void Main(string[] args)
		{
			int[] nights = { 0, 3, 5, 8 };
			double[] prices = { 200, 180, 160, 145 };
			int x, nightsEntry;
			double perNight = 0;
			Write("How many nights is your stay? ");
			nightsEntry = int.Parse(ReadLine());
			x = nights.Length - 1;
			while (x >= 0)
			{
				if (nightsEntry >= nights[x])
				{
					perNight = prices[x];
					x = 0;
				}
				x--;
			}
			if (nightsEntry > 0)
				WriteLine("Price per night is {0}", perNight.ToString("c"));
			WriteLine("Total for {0} night(s) is {1}", nightsEntry, (nightsEntry * perNight).ToString("c"));
		}
	}
}
