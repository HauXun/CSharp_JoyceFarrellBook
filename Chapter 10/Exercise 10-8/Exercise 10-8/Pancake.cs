using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10_8
{
	class Pancake : ITurnable
	{
		public void Turn()
		{
			Console.WriteLine("You turn a pancake when it's done on one side");
		}
	}
}
