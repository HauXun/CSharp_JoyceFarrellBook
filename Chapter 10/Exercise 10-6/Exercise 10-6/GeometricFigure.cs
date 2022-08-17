using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10_6
{
	abstract class GeometricFigure
	{
		protected int height;
		protected int width;
		protected int area;
		public abstract void ComputerArea();

		public int Height
		{
			get => height;
			set
			{
				height = value;
				ComputerArea();
			}
		}

		public int Width
		{
			get => width;
			set
			{
				width = value;
				ComputerArea();
			}
		}

		public int Area 
		{
			get => area;
		}

		public GeometricFigure(int h, int w)
		{
			Height = h;
			Width = w;
		}
	}
}
