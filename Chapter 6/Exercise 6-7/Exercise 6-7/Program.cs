/*
The Nimble Fingers Typing School assigns grades based on words typed per minute,
as shown in Figure 6-26. Write a program named TypingGrades that allows a user to
enter a student’s number of words typed. The output is the letter grade

Words typed		Grade
0–15			F
16–30			D
31–50			C
51–75			B
76 and over		A
 */



using System;
using static System.Console;

namespace Exercise_6_7
{
	class TypingGrades
	{
		static void Main(string[] args)
		{
			int[] wordLimits = { 0, 16, 31, 51, 76 };
			char[] grades = { 'F', 'D', 'C', 'B', 'A' };

			string isContinue = null;
			do
			{
				DateTime now = DateTime.Now;
				var x = now.Second;
				var m = now.Minute;
				WriteLine(" TYPING TEST\n");
				WriteLine(" The time now is {0} second", x);
				WriteLine(" You only have 1 minute, please enter...");
				string input = ReadLine();
				DateTime now1 = DateTime.Now;
				var x1 = now1.Second;
				var m1 = now1.Minute;
				if (x1 - x + 60 < 60 && m1 >= m)
				{
					WriteLine("If it take more than 1 minute, your result will not be accepted !");
					WriteLine("Cancel Result...!");
				}
				else
				{
					for (int i = wordLimits.Length - 1; i >= 0; i--)
						if (input.Length >= wordLimits[i])
						{
							WriteLine("\n\nTyping {0} words per minute... Grade {1}", input.Length, grades[i].ToString());
							i = 0;
						}
				}
				Write("\nWould you like to try again. Press Y/n to try or not");
				isContinue = ReadLine().ToLower();
			} while (isContinue != "y");
			Read();
		}
	}
}
