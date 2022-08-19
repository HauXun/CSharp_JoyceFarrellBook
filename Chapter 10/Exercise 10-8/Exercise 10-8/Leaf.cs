using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10_8
{
	class Leaf : ITurnable
	{
		public void Turn()
		{
			Console.WriteLine("A leaf turns colors in the fall");
		}
	}
}
