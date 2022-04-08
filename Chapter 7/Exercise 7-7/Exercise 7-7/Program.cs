/*
In Chapter 4, you wrote a program named Admission for a college admissions office
in which the user enters a numeric high school grade point average and an admission
test score. The program displays Accept or Reject based on those values. Now, create a
modified program named AdmissionModularized in which the grade point average
and test score are passed to a method that returns a string containing Accept or Reject
 */



using System;

namespace Exercise_7_7
{
	class Application
	{
		const double pointsAverage = 3.0;
		const int scoreAdmission1 = 60;
		const int scoreAdmission2 = 80;
		public double GPA, AdmissionScore;

		public bool IsAdmitted()
		{
			if (GPA >= pointsAverage && AdmissionScore >= scoreAdmission1)
				return true;
			else if (GPA < pointsAverage && AdmissionScore >= scoreAdmission2)
				return true;
			else
				return false;
		}
	}

	class AdmissionModularized
	{
		static void Main(string[] args)
		{
			Application a = new Application();

			Console.Write("Enter your GPA: ");
			double GPA = double.Parse(Console.ReadLine());
			a.GPA = GPA;
			Console.Write("Enter your admission score: ");
			double AdmissionScore = double.Parse(Console.ReadLine());
			a.AdmissionScore = AdmissionScore;

			if (a.IsAdmitted())
				Console.WriteLine(" Accept ");
			else
				Console.WriteLine(" Reject ");
		}
	}
}
