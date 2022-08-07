using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10_2
{
	class MattedPhoto : Photo
	{
		const double PREMIUM = 10;
		public string Color { get; set; }
		public override string ToString()
		{
			SetPrice(PREMIUM);
			return (GetType() + "\t" + Color + " matting " + Width + " x " + Height + " >> Price: " + Price.ToString("C"));
		}
	}
}
