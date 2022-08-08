/*
/*
a. Create an application named JobDemo that declares and uses Job objects. The
Job class holds job information for a home repair service. The class has five
properties that include a job number, customer name, job description, estimated
hours, and price for the job. Create a constructor that requires parameters for all
the data except price. Include auto-implemented properties for the job number,
customer name, and job description, but not for hours or price; the price field value
is calculated as estimated hours times $45.00 whenever the hours value is set. Also
create the following for the class:
• An Equals() method that determines two Jobs are equal if they have the same
job number
• A GetHashCode() method that returns the job number
• A ToString() method that returns a string containing all job information
The JobDemo application declares a few Job objects, sets their values, and
demonstrates that all the methods work as expected.
*/





using System;
using static System.Console;

namespace Exercise_10_3A
{
	class JobDemo
	{
		static void Main(string[] args)
		{
			Job job1 = new Job(111, "Smith", "Exterior Paint", 20);
			Job job2 = new Job(222, "Vega", "Gutter Clean", 4);
			Job job3 = new Job(111, "Land", "Black Drive", 10);
			WriteLine(job1.ToString());
			WriteLine(job2.ToString());
			WriteLine(job3.ToString());
			CompareNumber(job1, job2);
			CompareNumber(job1, job3);
		}
		internal static void CompareNumber(Job job1, Job job2)
		{
			if (job1.Equals(job2))
				WriteLine("{0} for {1} has the same job " + " number as " + "{2} for {3}",
					job1.JobNumber, job1.Customer, job2.JobNumber, job2.Customer);
		}
	}
}
