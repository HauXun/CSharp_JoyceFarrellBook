/*
c. Create a RushJob class that derives from Job. A RushJob has a $150.00 premium
that is added to the normal price of the job. Override any methods in the parent
class as necessary. Write a new application named JobDemo3 that creates an array
of five RushJobs. Prompt the user for values for each, and do not allow duplicate
job numbers. When five valid RushJob objects have been entered, display them all,
plus a total of all prices.
 */





using System;
using static System.Console;

namespace Exercise_10_3C
{
	class JobDemo3
	{
		static void Main(string[] args)
		{
			RushJob[] job = new RushJob[2];
			double grandTotal = 0;
			bool goodNumber;
			for (int i = 0; i < job.Length; i++)
			{
				job[i] = new RushJob();
				Write("Enter job number >> ");
				job[i].JobNumber = int.Parse(ReadLine());
				goodNumber = true;
				for (int j = 0; j < i; j++)
				{
					if (job[i].Equals(job[j]))
						goodNumber = false;
				}
				while (!goodNumber)
				{
					WriteLine("Sorry, the job number " + job[i].JobNumber + " is a dublicate. " + "\nPlease reenter >> ");
					job[i].JobNumber = int.Parse(ReadLine());
					goodNumber = true;
					for (int j = 0; j < i; j++)
					{
						if (job[i].Equals(job[j]))
							goodNumber = false;
					}
				}
				Write("\nEnter customer name >> ");
				job[i].Customer = ReadLine();
				Write("\nEnter job description >> ");
				job[i].Description = ReadLine();
				Write("\nEnter estimated hours for job >> ");
				job[i].Hours = double.Parse(ReadLine());
				WriteLine("\n");
			}
			WriteLine("\n\t\t\tSUMARY\n");
			for (int i = 0; i < job.Length; i++)
			{
				WriteLine(job[i].ToString());
				grandTotal += job[i].Price;
			}
			WriteLine("\nTotal for all job is: " + grandTotal.ToString("c"));
		}
	}
}
