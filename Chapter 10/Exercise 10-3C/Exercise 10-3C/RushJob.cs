using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10_3C
{
	class RushJob : Job, IComparable
	{
		public const double PREMIUM = 150.00;

		public RushJob() : base(0, null, null, 0)
		{
		}

		public override string ToString()
		{
			return (GetType() + " " + JobNumber + " " + Customer + " " + Description + " " + Hours +
					" hours @" + RATE.ToString("C") +
					" per hour. Rush job adds " + PREMIUM + " premium. Total price is " + Price.ToString("C"));
		}

		public new double Hours
		{
			get => hours;
			set
			{
				hours = value;
				price = hours * RATE + PREMIUM;
			}
		}

		int IComparable.CompareTo(object obj)
		{
			RushJob temp = (RushJob)obj;
			if (this.JobNumber > temp.JobNumber)
				return 1;
			else
				if (this.JobNumber < temp.JobNumber)
				return -1;
			else
				return 0;
		}
	}
}
