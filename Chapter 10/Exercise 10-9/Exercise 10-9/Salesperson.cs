using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10_9
{
	abstract class Salesperson
	{
		private string firstName;
		private string lastName;

		protected string LastName { get; set; }
		protected string FirstName { get; set; }

		public Salesperson(string first, string last)
		{
			FirstName = first;
			LastName = last;
		}

		public string GetName() => FirstName + " " + LastName;
	}
}
