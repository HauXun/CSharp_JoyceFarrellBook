using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Exercise_10_9
{
	class RealEstateSaleperson : Salesperson, ISellable
	{
		public double CommissionRate { get; set; }
		public double TotalCommissionEarned { get; set; }
		public int TotalValueSold { get; set; }

		public RealEstateSaleperson(string first, string last, double rate) : base (first, last)
		{
			CommissionRate = rate;
		}

		public void SalesSpeech()
		{
			WriteLine("This property will double in value in the next ten year");
			WriteLine("Buy it now or regret it forever.");
			WriteLine();
		}

		public void MakeSale(int amt)
		{
			TotalValueSold += amt;
			TotalCommissionEarned = TotalValueSold * CommissionRate;
		}
	}
}
