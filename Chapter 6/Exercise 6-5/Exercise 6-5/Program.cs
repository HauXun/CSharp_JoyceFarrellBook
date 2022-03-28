/*
Write a program called DeliveryCharges for the package delivery service in Exercise 4.
The program should again use an array that holds the 10 zip codes of areas to which
the company makes deliveries. Create a parallel array containing 10 delivery charges
that differ for each zip code. Prompt a user to enter a zip code, and then display either
a message indicating the price of delivery to that zip code or a message indicating that
the company does not deliver to the requested zip code.
 */



using System;
using System.Globalization;
using static System.Console;

namespace Exercise_6_5
{
	class DeliveryCharges
	{
		public static void Main(string[] args)
		{
			string[] zipCode = { "DALAT", "SAIGON", "NGHEAN", "CAMAU", "VINHLONG",
				"BACLIEU", "HANOI", "HAIPHONG", "HAGIANG", "PHUYEN" };
			double[] zipPrice = { 14.323, 36.563, 34.655, 67.897, 13.243,
				43.321, 35.634, 76.856, 23.445, 12.354 };
			bool zipFound = false;
			WriteLine("Enter the Zip code for delivery: ");
			string code = ReadLine().ToUpper();
			for (int i = 0; i < zipCode.Length; i++)
			{
				if (code == zipCode[i])
				{
					WriteLine("Delivery to {0}. Accept!", code);
					WriteLine("The delivery price to this area code is {0}VND", zipPrice[i].ToString(CultureInfo.GetCultureInfo("vi-VN")));
					zipFound = true;
				}
			}
			if (!zipFound)
				WriteLine("The company does not deliver to the required zip code.");
			Read();
		}
	}
}
