/*
Write a program named DemoJobs for Harold’s Home Services. The program
should instantiate several Job objects and demonstrate their methods. The Job
class contains four data fields—description (for example, “wash windows”), time in
hours to complete (for example, 3.5), per-hour rate charged (for example, $25.00),
and total fee (hourly rate times hours). Include properties to get and set each field
except the total fee—that field will be read-only, and its value is calculated each
time either the hourly fee or the number of hours is set. Overload the + operator
so that two Jobs can be added. The sum of two Jobs is a new Job containing the
descriptions of both original Jobs (joined by and), the sum of the time in hours for
the original Jobs, and the average of the hourly rate for the original Jobs.
 */




using System;
using static System.Console;

namespace Exercise_9_10A
{
	class DemoJobs
	{
		static void Main(string[] args)
		{
			Job j1 = new Job();
			Job j2 = new Job();
			Job j3 = new Job();
			j1.Description = "Wash Windows";
			j1.Time = 3.5;
			j1.Hourly = 25.00;
			j1.Description = "Teaching Math";
			j1.Time = 2;
			j1.Hourly = 18.50;
			j3 = j1 + j2;
			Display(j1);
			Display(j2);
			Display(j3);
		}

		internal static void Display(Job j)
		{
			WriteLine("Job: {0} is {1} per hour for {2} hours.\n\tTotal = {3}",
				j.Description, j.Hourly.ToString("c"), j.Time.ToString("c"), j.Total.ToString("c"));
		}
	}
}
