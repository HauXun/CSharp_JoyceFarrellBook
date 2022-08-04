using System;

namespace Exercise_9_9B
{
	class Relative : IComparable
	{
		public string Name { get; set; }
		public string relationShip { get; set; }
		public int month { get; set; }
		public int day { get; set; }
		public int year { get; set; }

		int IComparable.CompareTo(object obj)
		{
			int returnVal;
			Relative temp = (Relative)obj;
			returnVal = this.Name.CompareTo(temp.Name);
			return returnVal;
		}
	}
}
