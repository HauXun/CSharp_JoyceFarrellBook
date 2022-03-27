/*
Write a program named CheckZips that is used by a package delivery service to check
delivery areas. The program contains an array that holds the 10 zip codes of areas to
which the company makes deliveries. Prompt a user to enter a zip code, and display a
message indicating whether the zip code is in the company’s delivery area.
 */



using System;
using static System.Console;

namespace Exercise_6_4
{
	class CheckZip
	{
		public static void Main(string[] args)
		{
			string[] zipCode = { "DALAT", "SAIGON", "NGHEAN", "CAMAU", "VINHLONG",
				"BACLIEU", "HANOI", "HAIPHONG", "HAGIANG", "PHUYEN" };
			bool zipFound = false;
			WriteLine("Enter the Zip code for delivery: ");
			string code = ReadLine().ToUpper();
			for (int i = 0; i < zipCode.Length; i++)
			{
				if (code == zipCode[i])
				{
					WriteLine("Delivery to {0}. Accept!", code);
					zipFound = true;
				}
			}
			if (!zipFound)
				WriteLine("The company does not deliver to the required zip code.");
			Read();
		}
	}
}
