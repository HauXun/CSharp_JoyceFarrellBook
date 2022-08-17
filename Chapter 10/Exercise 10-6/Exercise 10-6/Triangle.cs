using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10_6
{
	class Triangle : GeometricFigure
	{
		public Triangle(int h, int w) : base(h, w)
		{

		}

		public override void ComputerArea()
		{
			area = Width * Height / 2;
		}
	}
}
