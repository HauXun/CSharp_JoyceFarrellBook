/*
Create a program named SalesTaxDemo2 so that after the 10 Sale objects are
displayed, they are sorted in order by the amount of tax owed and displayed again.
Modify the Sale class so its objects are comparable to each other based on tax
owed.
 */




using System;
using static System.Console;

namespace Exersice_9_6B
{
	class SalesTaxDemo2
	{
		static void Main(string[] args)
		{
			// Number of objects
			int time = 10;
			Sale[] sale = new Sale[10];

			for (int i = 0; i < 10; i++)
				sale[i] = new Sale();
			for (int i = 0; i < time; i++)
			{
				Write("Enter inventory number #{0} >> ", i + 1);
				sale[i].InventoryNumber = ReadLine();
				Write("Enter amount of sale >> ");
				sale[i].Amount = double.Parse(ReadLine());
			}
			WriteLine("\n");

			// Printing details of every sale
			for (int i = 0; i < time; i++)
				WriteLine("Sale #{0} Amount: {1}\tSale: ${2}\tTax is ${3}", i + 1, sale[i].InventoryNumber,
					String.Format("{0:n}", sale[i].Amount), String.Format("{0:n}", sale[i].GetTax));

			WriteLine("\n");

			// Sorted
			Array.Sort(sale);
			WriteLine("".PadRight(10, '-') + "Sorted".PadRight(10, '-'));
			for (int i = 0; i < time; i++)
				WriteLine("Sale #{0} Amount: {1}\tSale: ${2}\tTax is ${3}", i + 1, sale[i].InventoryNumber,
					String.Format("{0:n}", sale[i].Amount), String.Format("{0:n}", sale[i].GetTax));
		}
	}
}
