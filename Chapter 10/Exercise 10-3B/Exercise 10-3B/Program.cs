/*
b. Using the Job class you created in Exercise 3a, write a new application named
JobDemo2 that creates an array of five Job objects. Prompt the user for values for
each Job. Do not allow duplicate job numbers; force the user to reenter the job
when a duplicate job number is entered. When five valid objects have been entered,
display them all, plus a total of all prices.
 */





using System;
using static System.Console;

namespace Exercise_10_3B
{
	class JobDemo2
	{
		static void Main(string[] args)
		{
			Job[] job = new Job[5];
			double grandTotal = 0;
			bool goodNumber;
			for (int i = 0; i < job.Length; i++)
			{
				job[i] = new Job(0, null, null, 0);
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
