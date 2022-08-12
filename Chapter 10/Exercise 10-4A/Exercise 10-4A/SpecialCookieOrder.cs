using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10_4A
{
	class SpecialCookieOrder : CookieOrder
	{
		public string SpecialDescription { get; set; }
		const int PRICE_CUTOFF = 40;
		const int LOW_SPECIAL = 8;
		const int HIGH_SPECIAL = 10;

		public override int Dozens
		{
			set
			{
				dozens = value;
				if (dozens <= CUTOFF)
					Price = dozens * HIGHPRICE;
				else
					Price = CUTOFF * HIGHPRICE + (dozens - CUTOFF) * LOWPRICE;
				if (Price < PRICE_CUTOFF)
					Price += HIGH_SPECIAL;
				else
					Price += LOW_SPECIAL;
			}
		}
	}
}
