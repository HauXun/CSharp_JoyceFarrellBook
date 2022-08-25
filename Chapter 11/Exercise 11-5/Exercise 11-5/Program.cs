/*
a. Create a program named BookExceptionDemo for the Peterman Publishing
Company. Create a BookException class that is instantiated when a Book’s price
exceeds 10 cents per page and whose constructor requires three arguments for
title, price, and number of pages. Create an error message that is passed to the
Exception class constructor for the Message property when a Book does not meet
the price-to-pages ratio. For example, an error message might be:
For Goodnight Moon, ratio is invalid.
…Price is $12.99 for 25 pages.
b. Create a Book class that contains fields for title, author, price, and number of pages.
Include properties for each field. Throw a BookException if a client program
tries to construct a Book object for which the price is more than 10 cents per page.
Create a program that creates at least four Book objects—some where the ratio is
acceptable, and others where it is not. Catch any thrown exceptions, and display
the BookException Message.
c. Using the Book class, write an application named BookExceptionDemo2 that
creates an array of five Books. Prompt the user for values for each Book. To handle
any exceptions that are thrown because of improper or invalid data entered by the
user, set the Book’s price to the maximum of 10 cents per page. At the end of the
program, display all the entered, and possibly corrected, records.
 */





using System;
using static System.Console;

namespace Exercise_11_5
{
	class BookExceptionDemo2
	{
		static void Main(string[] args)
		{
			Book[] book = new Book[5];
			string title = null;
			string author = null;
			double price = 0;
			int pages = 0;

			for (int i = 0; i < book.Length; i++)
			{
				try
				{
					Write("Enter title >> ");
					title = ReadLine();
					Write("Enter author >> ");
					author = ReadLine();
					Write("Enter price >> ");
					price = double.Parse(ReadLine());
					Write("Enter pages >> ");
					pages = int.Parse(ReadLine());
					book[i] = new Book(title, author, price, pages);
				}
				catch (FormatException fe)
				{
					WriteLine(fe.Message);
					book[i] = new Book(title, author, 0, 0);
				}
				catch (BookException be)
				{
					WriteLine(be.Message);
					book[i] = new Book(title, author, (pages * Book.RATE), pages);
				}
			}
			for (int i = 0; i < book.Length; i++)
			{
				WriteLine(book[i].ToString());
			}
		}
	}
}
