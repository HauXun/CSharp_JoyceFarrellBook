/*
Create a C# statement that uses each of the following built-in methods you have
used in previous chapters, then make an intelligent guess about the return type and
parameter list for the method used in each statement you created.
a. Console.WriteLine()
b. String.Equals()
c. String.Compare()
d. Convert.ToInt32()
e. Convert.ToChar()
f. Array.Sort()
 */




using System;
using static System.Console;

namespace Exercise_7_1
{
	class Program
	{
		public static void Main(string[] args)
		{
			WriteLine("Hello World!");
			string a = null, b = null;
			Equal(a, b);
			comPare(a, b);
			conVert();
			toChar(a);
			Sort();
		}

		public static void Equal(string a, string b)
		{
			Write("Enter string a: ");
			a = ReadLine();
			Write("Enter string b: ");
			b = ReadLine();

			if (a.Equals(b))
				WriteLine("Equals.");
			else
				WriteLine("Not Equals.");
		}

		public static void comPare(string a, string b)
		{
			Write("Enter string a: ");
			a = ReadLine();
			Write("Enter string b: ");
			b = ReadLine();
			if (string.Compare(a, b) == 0)
				WriteLine("Equals");
			else if (string.Compare(a, b) > 0)
				WriteLine("Bigger");
			else
				WriteLine("Smaller");
		}

		public static double conVert()
		{
			WriteLine("Enter a: ");
			var a = double.Parse(ReadLine());
			WriteLine("a before convert {0}", a);
			WriteLine("a after convert {0}", Convert.ToInt32(a));
			return a;
		}

		public static void toChar(string a)
		{
			WriteLine("Enter string a: ");
			a = ReadLine();
			WriteLine("a before convert {0}", a);
			WriteLine("a after convert {0}", Convert.ToChar(a));
		}

		public static void Sort()
		{
			string[] a = new string[] { "1", "3", "2", "5", "2", "1", "8", "4", "6", "5" };
			WriteLine("\nArray before sort...");
			for (int i = 0; i < a.Length; i++)
				Write("{0, 6}", a[i]);

			Array.Sort(a);
			WriteLine("\nArray after sort...");
			for (int i = 0; i < a.Length; i++)
				Write("{0, 6}", a[i]);
		}
	}
}
