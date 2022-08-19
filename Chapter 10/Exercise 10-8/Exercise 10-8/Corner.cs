using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10_8
{
	class Corner : ITurnable
	{
		public void Turn()
		{
			Console.WriteLine("You turn corners to go around the block");
		}
	}
}
