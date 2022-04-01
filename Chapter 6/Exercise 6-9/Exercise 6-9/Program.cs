/*
In Chapter 5, you wrote a HomeSales application for three salespeople: Danielle,
Edward, and Francis. Now, modify the program to use arrays to store the salesperson
names, allowed initials, and accumulated sales values.
 */



using System;
using System.Globalization;
using static System.Console;

namespace Exercise_6_9
{
	class HomeSales
	{
		static void Main(string[] args)
		{
			string sentinel = "";
			double[] sales = new double[3];
			string[] initials = new string[3];
			string[] names = new string[3];

			int i;

			for (i = 0; i < sales.Length; i++)
				sales[i] = 0;

			initials[0] = "d";
			initials[1] = "e";
			initials[2] = "f";

			names[0] = "Danielle";
			names[1] = "Edward";
			names[2] = "Francis";

			double total = 0;
			// Iterates till the user entered sentinel is z
			while (sentinel != "z")
			{
				do
				{
					WriteLine("\n --- Enter Z or z to stop program ---");
					Write("Enter the abbreviation of the seller (D, E, or F): ");
					sentinel = ReadLine().ToLower();
					if (sentinel.Length > 1)
						WriteLine("\nYou must enter a character...");
				} while (sentinel.Length > 1);
				for (i = 0; i < initials.Length; i++)
				{
					if (initials[i] == sentinel)
						break;
				}
				if (i != initials.Length)
				{
					WriteLine("\nYou have entered {0}'s name", names[i]);
					Write("Enter amount of Sale: ");
					sales[i] += double.Parse(ReadLine());
				}
				else if (sentinel != "z")
				{
					WriteLine("\nSorry - Invalid Salesperson. \nYou must enter the seller's initials (D, E or F) \nPress anykey to continue...!");
					ReadKey();
				}
				if (sentinel == "z")
				{
					WriteLine("\nThanks for using the program! Goodbye...");
					ReadLine();
				}
			}
			for (i = 0; i < sales.Length; i++)
			{
				total += sales[i];
				WriteLine("\n{0} sold: {1}", names[i], sales[i].ToString("c", CultureInfo.GetCultureInfo("en-US")));
			}
			if (sales[0] > sales[1] && sales[0] > sales[2])
				WriteLine("\nDanielle sold the most !");
			else if (sales[2] > sales[0] && sales[2] > sales[1])
				WriteLine("\nFrancis sold the most !");
			else
				WriteLine("\nEdward sold the most !");
			ReadLine();
		}
	}
}
