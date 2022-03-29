/*
The Chat-A-While phone company provides service to six area codes and charges
the per-minute rates for phone calls shown in Figure 6-25. Write a program named
ChatAWhile that stores the area codes and rates in parallel arrays and allows a user
to enter an area code and the length of time for a call in minutes, and then display the
total cost of the call.
 */



using System;
using static System.Console;

namespace Exercise_6_6
{
	class ChatAWhile
	{
		static void Main(string[] args)
		{
			int[] areaCode = { 262, 414, 608, 715, 815, 920 };
			double[] rate = { 0.07, 0.10, 0.05, 0.16, 0.24, 0.14 };

			WriteLine("Area code List");
			for (int i = 0; i < 55; i++)
				Write("-");
			Write("\n");
			for (int i = 0; i < areaCode.Length; i++)
				Write("{0, 6} | ", areaCode[i]);
			Write("\n");
			Write("\nEnter the area code from the above list: ");
			int inputCode = int.Parse(ReadLine());
			Write("Enter the duration (in minutes) of the call: ");
			int minutes = int.Parse(ReadLine());
			int x = Array.BinarySearch(areaCode, inputCode);
			WriteLine("The total cost of the call is {0:c}", rate[x] * minutes);
			ReadLine();
		}
	}
}
