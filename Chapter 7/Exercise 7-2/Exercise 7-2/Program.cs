/*
Create a program named SalesLetter whose Main() method uses several
WriteLine() calls to display a sales letter to prospective clients for a business of your
choice. Display your contact information at least three times in the letter. The contact
information should contain at least three lines with data such as land line phone
number, cellphone number, email address, and so on. Each time you want to display
the contact information, call a method named DisplayContactInfo().
 */




using System;
using static System.Console;

namespace Exercise_7_2
{
	class SalesLetter
	{
		static void Main(string[] args)
		{
			WriteLine("My sales letter details");
			WriteLine("DisplayContactInfo() method called: ");
			DisplayContactInfo();
		}

		static void DisplayContactInfo()
		{
			WriteLine("\nCellphone Number: 92807345278");
			WriteLine("Landine Number: 1227318291");
			WriteLine("Email ID: carl@xmail.com");
		}
	}
}
