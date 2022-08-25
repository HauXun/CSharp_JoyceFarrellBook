using System;

namespace Exercise_11_5
{
	class Book
	{
		private string title;
		private string author;
		private double price;
		private int pages;
		public const double RATE = 0.10;

		public string Title { get => title; set => title = value; }
		public string Author { get => author; set => author = value; }
		public double Price { get => price; set => price = value; }
		public int Pages { get => pages; set => pages = value; }

		public Book(string title, string author, double price, int pages)
		{
			Title = title;
			Author = author;
			if (price > RATE * pages)
				throw (new BookException(title, price, pages));
			Price = price;
			Pages = pages;
		}

		public new string ToString() => $"{title} by {author} Price {price.ToString("C")} {pages} pages";
	}
}