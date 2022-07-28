/*
Create an application named SalesTransactionDemo that declares
several SalesTransaction objects and displays their values and their sum.
The SalesTransaction class contains fields for a salesperson name, sales amount,
and commission and a readonly field that stores the commission rate. Include three
constructors for the class. One constructor accepts values for the name, sales amount,
and rate, and when the sales value is set, the constructor computes the commission as
sales value times commission rate. The second constructor accepts a name and sales
amount, but sets the commission rate to 0. The third constructor accepts a name and
sets all the other fields to 0. An overloaded + operator adds the sales values for two
SalesTransaction objects.
 */




using System;
using static System.Console;

namespace Exercise_9_3
{
	class SalesTransactionDemo
	{
		static void Main(string[] args)
		{
			SalesTransaction s1 = new SalesTransaction("SonTung", 2000, 0.20);
			SalesTransaction s2 = new SalesTransaction("Chipu", 4000);
			SalesTransaction s3 = new SalesTransaction("HaiDU");
			SalesTransaction total = s1 + s2 + s3;
			Display(s1);
			Display(s2);
			Display(s3);
			DisplayTotal(total);
		}

		public static void Display(SalesTransaction s)
		{
			Write("{0} had sales totaling {1}.", s.Name, s.SalesAmount);
			WriteLine(" Commission rate is {0}; Commission  value is {1}", s.Rate, s.Commission);
		}

		public static void DisplayTotal(SalesTransaction s)
		{
			Write("Total sales: {0}", s.SalesAmount.ToString("c"));
		}
	}
}
