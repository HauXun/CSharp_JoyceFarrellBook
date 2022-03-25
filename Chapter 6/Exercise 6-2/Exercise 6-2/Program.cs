/*
Write a program named TestScoreList that accepts eight int values representing
student test scores. Display each of the values along with a message that indicates how
far it is from the average
 */



using System;
using static System.Console;

namespace Exercise_6_2
{
	class TestScoreList
	{
		static void Main(string[] args)
		{
			int[] score = new int[8];
			double sum = 0;
			for (int i = 0; i < 8; i++)
			{
				Write("{0} - Please enter scores for the test: ", i + 1);
				score[i] = int.Parse(ReadLine());
				sum += score[i];
			}
			double avg = sum / 8;
			for (int i = 0; i < 8; i++)
				WriteLine("Test #{0}: \t{1} ways the average is {2}", i + 1, score[i], score[i] - avg);
			WriteLine("Total is: {0}", sum);
			WriteLine("Average is: {1}", avg);
			ReadLine();
		}
	}
}
