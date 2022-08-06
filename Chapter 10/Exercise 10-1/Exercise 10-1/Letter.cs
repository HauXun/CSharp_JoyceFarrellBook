using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10_1
{
	class Letter
	{
		public string Name { get; set; }
		public string Date { get; set; }
		public override string ToString()
		{
			return (GetType() + ":" + this.Name + "" + this.Date);
		}
	}
}
