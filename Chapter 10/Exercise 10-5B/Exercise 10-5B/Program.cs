/*
b. Using the Automobile class as a base, derive a FinancedAutomobile class that
contains all the data of an Automobile, plus fields to hold the amount financed
and interest rate. Override the parent class ToString() method to include
the child class’s additional data. Create a program named AutomobileDemo2
that contains an array of four FinancedAutomobile objects. Prompt the user
for all the necessary data, and do not allow duplicate ID numbers and do not
allow the amount financed to be greater than the price of the automobile. Sort
all the records in ID number order and display them with a total price for all
FinancedAutomobiles and a total amount financed.
 */





using System;
using static System.Console;

namespace Exercise_10_5B
{
	class AutomobileDemo2
	{
		static void Main(string[] args)
		{
			FinancedAutomobile[] automobiles = new FinancedAutomobile[8];
			double grandTotal = 0;
			double grandTotalFinanced = 0;
			bool goodNumber;
			for (int i = 0; i < automobiles.Length; i++)
			{
				automobiles[i] = new FinancedAutomobile();
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
				Write("Enter amount financed >> ");
				automobiles[i].AmtFinanced = double.Parse(ReadLine());
				if (automobiles[i].AmtFinanced > automobiles[i].Price)
				{
					WriteLine("Amount financed is too large - charging to {0}", automobiles[i].Price.ToString("c"));
					automobiles[i].AmtFinanced = automobiles[i].Price;
				}
			}
			WriteLine("\n\t\t\tSUMARY");
			Array.Sort(automobiles);
			for (int i = 0; i < automobiles.Length; i++)
			{
				WriteLine(automobiles[i].ToString());
				grandTotal += automobiles[i].Price;
				grandTotalFinanced += automobiles[i].AmtFinanced;
			}
			WriteLine("Total for all Automobile is >> " + grandTotal.ToString("c"));
			WriteLine("Total financed all Automobile is >> " + grandTotalFinanced.ToString("c"));
		}
	}
}
