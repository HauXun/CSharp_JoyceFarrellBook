using System;

namespace Exercise_9_3
{
	class SalesTransaction
	{
		readonly double rate;
		public double salesAmount;
		public double commission;

		public string Name { get; set; }
		public double SalesAmount
		{
			get => salesAmount;
			set
			{
				salesAmount = value;
				commission = salesAmount * rate;
			}
		}
		public double Commission
		{
			get => commission;
		}

		public double Rate
		{
			get => rate;
		}

		public SalesTransaction(string name, double salesAmount, double rate)
		{
			Name = name;
			this.rate = rate;
			SalesAmount = salesAmount;
		}

		public SalesTransaction(string name) : this (name, 0, 0)
		{

		}

		public SalesTransaction(string name, double salesAmount) : this (name, salesAmount, 0)
		{

		}

		public static SalesTransaction operator +(SalesTransaction s1, SalesTransaction s2)
		{
			double total;
			total = s1.salesAmount + s2.salesAmount;
			SalesTransaction temp = new SalesTransaction("Total", total);
			return temp;
		}
	}
}
