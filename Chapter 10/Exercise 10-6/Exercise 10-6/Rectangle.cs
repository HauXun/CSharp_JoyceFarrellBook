using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10_6
{
	class Rectangle : GeometricFigure
	{
		public Rectangle(int h, int w) : base(h, w)
		{

		}

		public override void ComputerArea()
		{
			area = Width * Height;
		}
	}
}
