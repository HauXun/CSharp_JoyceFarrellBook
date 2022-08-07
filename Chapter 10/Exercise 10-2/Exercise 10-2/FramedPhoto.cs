using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10_2
{
	class FramedPhoto : Photo
	{
		const double PREMIUM = 25;
		public string Material { get; set; }
		public string Style { get; set; }
		public override string ToString()
		{
			SetPrice(PREMIUM);
			return (GetType() + "\t" + Style + ", " + Material + " frame. " +
				Width + " x " + Height + " >> Price: " + Price.ToString("C"));
		}
	}
}
