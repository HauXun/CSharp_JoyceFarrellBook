/*
Create a program named StudentGradeDemo that attempts to create several valid
and invalid ReportCard objects. Immediately after each instantiation attempt, handle
any thrown exceptions by displaying an error message. Create a ReportCard class
with four fields for a student name, a numeric midterm grade, a numeric final exam
grade, and letter grade. The ReportCard constructor requires values for the name
and two numeric grades and determines the letter grade. Upon construction, throw
an ArgumentException if the midterm or final exam grade is less than 0 or more
than 100. The letter grade is based on the arithmetic average of the midterm and
final exams using a grading scale of A for an average of 90 to 100, B for 80 to 90, C
for 70 to 80, D for 60 to 70, and F for an average below 60. Display all the data if the
instantiation is successful.
 */




using System;
using static System.Console;

namespace Exercise_11_4
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				ReportCard reportCard1 = new ReportCard("Adams", 80, 85);
			}
			catch (ArgumentException e)
			{
				WriteLine("{0} {1}", "reportCard1", e.Message);
			}

			try
			{
				ReportCard reportCard2 = new ReportCard("Brown", 20, 75);
			}
			catch (ArgumentException e)
			{
				WriteLine("{0} {1}", "reportCard2", e.Message);
			}

			try
			{
				ReportCard reportCard3 = new ReportCard("Cook", 100, 99);
			}
			catch (ArgumentException e)
			{
				WriteLine("{0} {1}", "reportCard3", e.Message);
			}

			try
			{
				ReportCard reportCard4 = new ReportCard("Dee", -1, 85);
			}
			catch (ArgumentException e)
			{
				WriteLine("{0} {1}", "reportCard4", e.Message);
			}

			try
			{
				ReportCard reportCard5 = new ReportCard("Edwards", 80, 101);
			}
			catch (ArgumentException e)
			{
				WriteLine("{0} {1}", "reportCard5", e.Message);
			}
		}
	}
}
