/*
a. Create an application named AutomobileDemo that prompts a user for data for
eight Automobile objects. The Automobile class includes auto-implemented
properties for ID number, make, year, and price. Override the ToString() method
to return all the details for an Automobile. During data entry, reprompt the user if
any ID number is a duplicate. Sort the objects in ID number order, and display all
their data as well as a total of all their prices.
 */





using System;
using static System.Console;

namespace Exercise_10_5A
{
	class AutomobileDemo
	{
		static void Main(string[] args)
		{
			Automobile[] automobiles = new Automobile[8];
			double grandTotal = 0;
			bool goodNumber;
			for (int i = 0; i < automobiles.Length; i++)
			{
				automobiles[i] = new Automobile();
				Write("Enter automobile ID number >> ");
				automobiles[i].IdNumber = int.Parse(ReadLine());
				goodNumber = true;
				for (int j = 0; j < i; j++)
				{
					if (automobiles[i].Equals(automobiles[j]))
						goodNumber = false;
				}
				while (!goodNumber)
				{
					Write("Sorry, the ID number " + automobiles[i].IdNumber + " is a duplicate. " + "\nPlease reenter >> ");
					automobiles[i].IdNumber = int.Parse(ReadLine());
					goodNumber = true;
					for (int j = 0; j < i; j++)
					{
						if (automobiles[i].Equals(automobiles[j]))
							goodNumber = false;
					}
				}
				Write("Enter make >> ");
				automobiles[i].Make = ReadLine();
				Write("Enter year >> ");
				automobiles[i].Year = int.Parse(ReadLine());
				Write("Enter price >> ");
				automobiles[i].Price = double.Parse(ReadLine());
			}
			WriteLine("\n\t\t\tSUMARY");
			for (int i = 0; i < automobiles.Length; i++)
			{
				WriteLine(automobiles[i].ToString());
				grandTotal += automobiles[i].Price;
			}
			WriteLine("Total for all Automobile is >> " + grandTotal.ToString("c"));
		}
	}
}
