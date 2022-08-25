using System;

namespace Exercise_11_5
{
	class BookException : Exception
	{
		public BookException(string title, double price, int pages) :
			base ("For " + title + ", ratio is invalid.\n...Price is " + price.ToString("C") + "for " + pages + "pages")
		{

		}
	}
}
