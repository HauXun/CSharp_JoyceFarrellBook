/*
a. Create a program named Reverse3 whose Main() method declares three integers
named firstInt, middleInt, and lastInt. Assign values to the variables,
display them, and then pass them to a method that accepts them as reference
variables, places the first value in the lastInt variable, and places the last value
in the firstInt variable. In the Main() method, display the three variables again,
demonstrating that their positions have been reversed.

b. Create a new program named Reverse4, which contains a method that reverses
the positions of four variables. Write a Main() method that demonstrates the
method works correctly.
 */




using System;
using static System.Console;

namespace Exercise_8_1
{
	class ReverseA
	{
		public static void reverse(ref int f, ref int m, ref int l)
		{
			int z = f;
			f = l;
			l = z;
		}
	}
	class Reverse
	{
		public static void reverse(ref int first, ref int second, ref int third, ref int fourth)
		{
			int tmp, tmp1;
			tmp = first;
			first = fourth;
			tmp1 = second;
			second = third;
			third = tmp1;
			fourth = tmp;
		}
	}

	class Reverse3
	{
		static void Main(string[] args)
		{
			int firstInt = 12;
			int middleInt = 23;
			int lastLint = 34;

			WriteLine($"\nCurrent value of first is {firstInt} middle is {middleInt} last is {lastLint}");
			ReverseA.reverse(ref firstInt, ref middleInt, ref lastLint);
			WriteLine($"\nNow, the first is {firstInt} middle is {middleInt} last is {lastLint}");
		}
	}
	class Reverse4
	{
		static void Main(string[] args)
		{

			int first = 12;
			int second = 23;
			int third = 34;
			int fourth = 45;

			WriteLine($"\nNumber in normal order: {first}, {second}, {third}, {fourth}");
			Reverse.reverse(ref first, ref second, ref third, ref fourth);
			WriteLine($"\nNumber in inverse order: {first}, {second}, {third}, {fourth}");
		}
	}
}
