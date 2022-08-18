using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10_7
{
	class Upholsterer : IRecoverable
	{
		public void Recover()
		{
			Console.WriteLine("I have new material for the couch");
		}
	}
}
