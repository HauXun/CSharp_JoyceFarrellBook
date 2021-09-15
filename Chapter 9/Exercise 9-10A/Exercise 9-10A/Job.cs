using System;

namespace Exercise_9_10A
{
	class Job
	{
		string description;
		double time;
		double hourly;
		double total;

		public string Description 
		{
			get => description;
			set
			{
				description = value;
			}
		}

		public double Time
		{
			get => time;
			set
			{
				time = value;
				CalcTotal();
			}
		}

		public double Hourly
		{
			get => hourly;
			set
			{
				hourly = value;
				CalcTotal();
			}
		}

		public double Total
		{
			get => total;
		}

		void CalcTotal()
		{
			total = time * hourly;
		}

		public static Job operator +(Job j1, Job j2)
		{
			Job temp = new Job();
			temp.description = j1.description + " and " + j2.description;
			temp.time = j1.time + j2.time;
			temp.hourly = j1.hourly + j2.hourly;
			return temp;
		}
	}
}
