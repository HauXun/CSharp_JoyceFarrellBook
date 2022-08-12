/*
a. Create an application for Nina’s Cookie Emporium named CookieDemo that
declares and demonstrates objects of the CookieOrder class and its descendants.
The CookieOrder class includes auto-implemented properties for an order
number, recipient’s name, and cookie type (for example, chocolate chip), and fields
for number of dozens ordered and price. When the field value for number of
dozens ordered is set, the price field is set as $15 per dozen for the first two dozen
and $13 per dozen for each dozen over two.
 */





using System;
using static System.Console;

namespace Exercise_10_4A
{
	class CookieDemo
	{
		static void Main(string[] args)
		{
			CookieOrder oneDoz = new CookieOrder();
			CookieOrder twoDoz = new CookieOrder();
			CookieOrder threeDoz = new CookieOrder();

			oneDoz.OderNumber = "101";
			oneDoz.Name = "Arthur";
			oneDoz.CookieType = "Chocolate Chip";
			oneDoz.Dozens = 1;

			twoDoz.OderNumber = "102";
			twoDoz.Name = "Brown";
			twoDoz.CookieType = "Peanut Butter";
			twoDoz.Dozens = 2;

			threeDoz.OderNumber = "103";
			threeDoz.Name = "Cooper";
			threeDoz.CookieType = "Sugar";
			threeDoz.Dozens = 3;

			Display(oneDoz);
			Display(twoDoz);
			Display(threeDoz);
		}

		public static void Display(CookieOrder order)
		{
			WriteLine("Order #{0, -6}\t{1, -15}", order.OderNumber, order.Name);
			WriteLine("\tType: {0}", order.CookieType);
			WriteLine("\t{0} dozen --- ${1}", order.Dozens, order.Price);
		}
	}
}
