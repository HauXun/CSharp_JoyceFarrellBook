/*
Harold has realized that his method for computing the fee for combined jobs is not
fair. For example, consider the following:
• His fee for painting a house is $100 per hour. If a job takes 10 hours, he earns
$1000.
• His fee for dog walking is $10 per hour. If a job takes 1 hour, he earns $10.
• If he combines the two jobs and works a total of 11 hours, he earns only the
average rate of $55 per hour, or $605.
Devise an improved, weighted method for calculating Harold’s fees for combined
Jobs and include it in the overloaded operator+() method. Write a program named
DemoJobs2 that demonstrates all the methods in the class work correctly.
 */




using System;
using static System.Console;

namespace Exercise_9_10B
{
	class DemoJobs2
	{
		static void Main(string[] args)
		{
			Job j1 = new Job();
			Job j2 = new Job();
			Job j3 = new Job();
			j1.Description = "Painting";
			j1.Time = 3.5;
			j1.Hourly = 25.00;
			j1.Description = "Dog Walking";
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
