/*
d. Make any necessary modifications to the RushJob class so that it can be sorted by
job number. Modify the JobDemo3 application so the displayed orders have been
sorted. Save the application as JobDemo4.
 */





using System;
using static System.Console;

namespace Exercise_10_3D
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
			Array.Sort(job);
			for (int i = 0; i < job.Length; i++)
			{
				WriteLine(job[i].ToString());
				grandTotal += job[i].Price;
			}
			WriteLine("\nTotal for all job is: " + grandTotal.ToString("c"));
		}
	}
}
