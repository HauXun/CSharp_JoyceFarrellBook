using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10_6
{
	class Square : Rectangle
	{
		public Square(int h, int w) : base (h, w)
		{

		}

		public Square(int h) : base (h, h)
		{

		}

		public new int Height
		{
			get => height;
			set
			{
				height = value;
				ComputerArea();
			}
		}

		public new int Width 
		{
			get => width;
			set
			{
				width = value;
				Console.WriteLine("XXX");
				ComputerArea();
			}
		}
	}
}
