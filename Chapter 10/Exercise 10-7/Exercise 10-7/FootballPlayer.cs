using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10_7
{
	class FootballPlayer : IRecoverable
	{
		public void Recover()
		{
			Console.WriteLine("I picked up the ball after a fumble");
		}
	}
}
