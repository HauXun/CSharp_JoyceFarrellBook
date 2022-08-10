using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10_3C
{
	class Job
	{
		public double hours;
		public double price;
		public const double RATE = 45.00;

		public int JobNumber { get; set; }
		public string Customer { get; set; }
		public string Description { get; set; }
		public double Hours
		{
			get => hours;
			set
			{
				hours = value;
				price = hours * RATE;
			}
		}

		public double Price
		{
			get => price;
		}

		public Job(int num, string cust, string desc, double hrs)
		{
			JobNumber = num;
			Customer = cust;
			Description = desc;
			Hours = hrs;
		}

		public override string ToString()
		{
			return (GetType() + " " + JobNumber + " " + Customer + " " + Description + " " + Hours +
				" hours @" + RATE.ToString("c") + " per hour. Total price is " + Price.ToString("c"));
		}

		public override bool Equals(object obj)
		{
			bool equal;
			Job temp = (Job)obj;
			if (JobNumber == temp.JobNumber)
				equal = true;
			else
				equal = false;
			return equal;
		}

		public override int GetHashCode() => JobNumber;
	}
}
