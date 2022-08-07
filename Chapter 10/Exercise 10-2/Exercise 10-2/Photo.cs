using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10_2
{
	class Photo
	{
		double width = 0;
		double height = 0;
		protected double price;
		const double SIZEWIDTH1 = 8;
		const double SIZEHEIGHT1 = 10;
		const double SIZEPRICE1 = 3.99;
		const double SIZEWIDTH2 = 10;
		const double SIZEHEIGHT2 = 12;
		const double SIZEPRICE2 = 5.99;
		const double CUSTOMPRICE = 9.99;

		public double Width 
		{
			get => width;
			set
			{
				width = value;
				SetPrice(0);
			}
		}

		public double Height
		{
			get => height;
			set
			{
				height = value;
				SetPrice(0);
			}
		}

		public double Price 
		{
			get => price;
		}

		protected void SetPrice(double premium)
		{
			if (width == SIZEWIDTH1 && height == SIZEHEIGHT1)
				price = SIZEPRICE1;
			else
				if (width == SIZEWIDTH2 && height == SIZEHEIGHT2)
				price = SIZEPRICE2;
			else
				price = CUSTOMPRICE;
			price += premium;
		}

		public override string ToString() => (GetType() + "\t" + Width + " x " + Height + " >> Price: " + Price.ToString("c"));
	}
}
