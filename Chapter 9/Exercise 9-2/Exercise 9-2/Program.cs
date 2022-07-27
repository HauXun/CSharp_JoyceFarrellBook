/*
Create an application named TestClassifiedAd that instantiates and displays at least
two ClassifiedAd objects. A ClassifiedAd has fields for a category (for example,
Used Cars), a number of words, and a price. Include properties that contain get and
set accessors for the category and number of words, but only a get accessor for the
price. The price is calculated at nine cents per word.
 */




using System;
using static System.Console;

namespace Exercise_9_2
{
	class TestClassifiedAd
	{
		static void Main(string[] args)
		{
			ClassifiedAd myClassifiedAd = new ClassifiedAd();
			ClassifiedAd yourClassifiedAd = new ClassifiedAd();
			myClassifiedAd.Category = "Used cars";
			myClassifiedAd.Words = 100;
			yourClassifiedAd.Category = "Help wanted";
			yourClassifiedAd.Words = 60;
			WriteLine("The classified ad with {0} words in category {1} costs {2}", myClassifiedAd.Words, myClassifiedAd.Category, myClassifiedAd.price.ToString("c"));
			WriteLine("The classified ad with {0} words in category {1} costs {2}", yourClassifiedAd.Words, yourClassifiedAd.Category, yourClassifiedAd.price.ToString("c"));
		}
	}
}
