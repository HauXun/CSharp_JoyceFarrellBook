/*
c. Write an application named AutomobileDemo3 that uses an extension method
for the FinancedAutomobile class. The method computes and returns a
FinancedAutomobile’s monthly payment due (1/24 of the amount financed). The
application should allow the user to enter data for four objects and then display all
the data for each.
 */





using System;
using static System.Console;

namespace Exercise_10_5C
{
	static class AutomobileDemo3
	{
		static void Main(string[] args)
		{
			FinancedAutomobile[] automobiles = new FinancedAutomobile[2];
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
				WriteLine("\n");
			}
			WriteLine("\n\t\t\tSUMARY");
			Array.Sort(automobiles);
			for (int i = 0; i < automobiles.Length; i++)
			{
				WriteLine(automobiles[i].ToString());
				WriteLine("\tPayment is {0}", automobiles[i].GetPaymentAmount().ToString("c"));
				grandTotal += automobiles[i].Price;
				grandTotalFinanced += automobiles[i].AmtFinanced;
			}
			WriteLine("Total for all Automobile is >> " + grandTotal.ToString("c"));
			WriteLine("Total financed all Automobile is >> " + grandTotalFinanced.ToString("c"));
		}
		static double GetPaymentAmount(this FinancedAutomobile fa)
		{
			const int PMTS = 24;
			return fa.AmtFinanced / PMTS;
		}
	}
}
