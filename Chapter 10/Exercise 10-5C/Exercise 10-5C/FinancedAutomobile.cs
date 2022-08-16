using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10_5C
{
	class FinancedAutomobile : Automobile, IComparable
	{
		public double AmtFinanced { get; set; }

		public FinancedAutomobile(int num, string make, int year, double price, double amtFinanced) : base(num, make, year, price)
		{
			AmtFinanced = amtFinanced;
		}

		public FinancedAutomobile() : this(0, "", 0, 0, 0)
		{

		}

		public override string ToString()
		{
			string temp = base.ToString();
			return temp += " Amount Financed >> " + AmtFinanced.ToString("c");
		}
	}
}
