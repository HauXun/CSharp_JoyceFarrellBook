/*
Write a program named InputMethodDemo2 that eliminates the repetitive code
in the InputMethod() in the InputMethodDemo program in Figure 8-5. Rewrite the
program so the InputMethod() contains only two statements:
one = DataEntry("first");
two = DataEntry("second");
 */




using System;
using static System.Console;

namespace Exercise_8_6
{
	class InputChange
	{
		public int first, second;

		public void InputMethod(out int one, out int two)
		{
			one = DataEntry("first");
			two = DataEntry("second");
		}

		public int DataEntry(string category)
		{
			int input;
			Write($"Enter {category} integer >> ");
			input = int.Parse(ReadLine());
			return input;
		}
	}
	class InputMethodDemo2
	{
		static void Main(string[] args)
		{
			InputChange a = new InputChange();

			a.InputMethod(out a.first, out a.second);
			WriteLine($"\nAfter InputMethod first is {a.first} and second is {a.second}");
		}
	}
}
