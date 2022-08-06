/*
Create an application class named LetterDemo that instantiates objects of two classes
named Letter and CertifiedLetter and that demonstrates all their methods.
The classes are used by a company to keep track of letters they mail to clients. The
Letter class includes auto-implemented properties for the name of the recipient
and the date mailed. Also, include a ToString() method that overrides the Object
class’s ToString() method and returns a string that contains the name of the class
(using GetType()) and the Letter’s data field values. Create a child class named
CertifiedLetter that includes an auto-implemented property that holds a tracking
number for the letter
 */




using System;
using static System.Console;

namespace Exercise_10_1
{
	class LetterDemo
	{
		static void Main(string[] args)
		{
			Letter let1 = new Letter();
			let1.Name = "\nSender: Son Tung";
			let1.Date = "\nDate: Feb, 2021";

			CertifiedLetter track = new CertifiedLetter();
			WriteLine("\nYour letter has been recived...");
			WriteLine(let1);
			WriteLine("\nTracking number: " + track.GetHashCode());
		}
	}
}
