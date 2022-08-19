using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10_8
{
	class Page : ITurnable
	{
		public void Turn()
		{
			Console.WriteLine("You turn a page in a book");
		}
	}
}
