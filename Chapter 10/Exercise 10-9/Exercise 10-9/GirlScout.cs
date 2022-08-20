using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Exercise_10_9
{
	class GirlScout : Salesperson, ISellable
	{
		public int TotalBoxes { get; set; }

		public GirlScout(string first, string last) : base (first, last)
		{
			TotalBoxes = 0;
		}

		public void SalesSpeech()
		{
			WriteLine("Would you like to buy someone cookies?");
			WriteLine("They are delicious and they help us go to camp");
			WriteLine();
		}

		public void MakeSale(int boxes)
		{
			TotalBoxes += boxes;
		}
	}
}
