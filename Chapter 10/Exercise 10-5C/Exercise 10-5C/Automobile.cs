using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10_5C
{
	class Automobile : IComparable
	{
		public int IdNumber { get; set; }
		public string Make { get; set; }
		public int Year { get; set; }
		public double Price { get; set; }

		public Automobile(int num, string make, int year, double price)
		{
			IdNumber = num;
			Make = make;
			Year = year;
			Price = price;
		}

		public Automobile() : this(999, "ZZZ", 0, 0)
		{

		}

		public override string ToString()
		{
			return (GetType() + " " + IdNumber + " " + Year + " " + Make + " Price is " + Price.ToString("c"));
		}

		public override int GetHashCode()
		{
			return IdNumber;
		}

		public override bool Equals(object obj)
		{
			Automobile temp = (Automobile)obj;
			if (this.IdNumber == temp.IdNumber)
				return true;
			else
				return false;
		}

		int IComparable.CompareTo(object obj)
		{
			Automobile temp = (Automobile)obj;
			if (this.IdNumber > temp.IdNumber)
				return 1;
			else
				if (this.IdNumber < temp.IdNumber)
				return -1;
			else
				return 0;
		}
	}
}
