using System;
using static System.Console;

namespace Exercise_11_4
{
	class ReportCard
	{
		private string name;
		private int midterm;
		private int final;
		private double average;
		private char grade = 'F';
		public const int LOWVALID = 0;
		public const int HIGHVALID = 100;
		public int[] CUTOFFS = { 90, 80, 70, 60 };
		public char[] GRADE = { 'A', 'B', 'C', 'D' };
		public ReportCard(string student, int mid, int fin)
		{
			if (mid < LOWVALID || mid > HIGHVALID)
				throw (new ArgumentException());
			if (fin < LOWVALID || fin > HIGHVALID)
				throw (new ArgumentException());
			average = (mid + fin) / 2.0;
			for (int i = CUTOFFS.Length - 1; i >= 0 ; i--)
			{
				if (average > CUTOFFS[i])
					grade = GRADE[i];
			}
			name = student;
			midterm = mid;
			final = fin;
			WriteLine("{0} report card created.", name);
			WriteLine("\tMidterm: {0} Final: {0}", midterm, final);
			WriteLine("\tAverage: {0} Grade: {0}", average, grade);
		}
	}
}
