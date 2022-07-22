/*
Create a program named FlexibleArrayMethod that declares at least three integer
arrays of different sizes. In turn, pass each array to a method that displays all the
integers in each array and their sum.
 */



using System;
using static System.Console;

namespace Exercise_7_10
{
	public class Items
	{
		public static int n;
		public int[] RandomNumbers(ref int n)
		{
			Write("\nEnter the number of element in the array: ");
			n = int.Parse(ReadLine());
			int[] a = new int[100];
			Random r = new Random();
			for (int i = 0; i < n; i++)
				a[i] = r.Next(1, 10);
			return a;
		}

		public void OutputAndSum(int[] temp, ref int length)
		{
			int count = 0;
			WriteLine("\n");
			for (int i = 0; i < length; i++)
			{
				Write(temp[i] + "\t");
				count++;
			}
			WriteLine($"\nThe length of the array is {length} and sum of array is {count}\n---------------------\n");
		}
	}
	class FlexibleArrayMethod
	{
		static void Main(string[] args)
		{
			Items any = new Items();
			int nA = 0, nB = 0, nC = 0;

			int[] a = any.RandomNumbers(ref nA);
			int[] b = any.RandomNumbers(ref nB);
			int[] c = any.RandomNumbers(ref nC);

			any.OutputAndSum(a, ref nA);
			any.OutputAndSum(b, ref nB);
			any.OutputAndSum(c, ref nC);
		}
	}
}
