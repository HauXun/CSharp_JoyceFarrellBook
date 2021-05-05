/*
In this chapter, you learned that although a double and a decimal both hold
floating-point numbers, a double can hold a larger value. Write a C# program named
DoubleDecimalTest that declares and displays two variables—a double and a
decimal. Experiment by assigning the same constant value to each variable so that the
assignment to the double is legal but the assignment to the decimal is not. In other
words, when you leave the decimal assignment statement in the program, an error message
should be generated that indicates the value is outside the range of the
type decimal, but when you comment out the decimal assignment and its output
statement, the program should compile correctly.
 */



using System;

namespace Exercise_2_4
{
	class DoubleDecimalTest
	{
		static void Main(string[] args)
		{
			double size = 10e + 52m;
			decimal length = 10e + 52m;
		}
	}
}
