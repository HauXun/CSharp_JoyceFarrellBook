using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10_4B
{
	class CookieOrder
	{
		public string OderNumber { get; set; }
		public string Name { get; set; }
		public string CookieType { get; set; }

		public const int LOWPRICE = 13;
		public const int HIGHPRICE = 15;
		public const int CUTOFF = 2;

		protected int dozens;
		public virtual int Dozens
		{
			get => dozens;
			set
			{
				dozens = value;
				if (Dozens <= CUTOFF)
					Price = Dozens * HIGHPRICE;
				else
					Price = CUTOFF * HIGHPRICE + (Dozens - CUTOFF) * LOWPRICE;
			}
		}
		public double Price { get; set; }
	}
}
