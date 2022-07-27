using System;

namespace Exercise_9_2
{
	class ClassifiedAd
	{
		const double PRICE_PER_WORD = 0.9;
		public int words;
		public double price;
		public string Category { get; set; }
		public int Words
		{
			get => words;
			set
			{
				words = value;
				price = words * PRICE_PER_WORD;
			}
		}

		public double Price
		{
			get => price;
		}
	}
}
