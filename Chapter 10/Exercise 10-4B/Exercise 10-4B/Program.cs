/*
b. Create a child class named SpecialCookieOrder, which includes a field with a
description as to why the order is special (for example, gluten-free). Override the
method that sets a CookieOrder’s price as described in part a, but also to include
special handling, which is $10 for orders up to $40 and $8 for higher-priced orders.
Create an application named CookieDemo2 that demonstrates using several
SpecialCookieOrder objects.
 */






using System;
using static System.Console;

namespace Exercise_10_4B
{
	class CookieDemo2
	{
		static void Main(string[] args)
		{
			SpecialCookieOrder oneDoz = new SpecialCookieOrder();
			SpecialCookieOrder twoDoz = new SpecialCookieOrder();
			SpecialCookieOrder threeDoz = new SpecialCookieOrder();

			oneDoz.OderNumber = "101";
			oneDoz.Name = "Arthur";
			oneDoz.CookieType = "Chocolate Chip";
			oneDoz.SpecialDescription = "Gluten-Free";
			oneDoz.Dozens = 1;

			twoDoz.OderNumber = "102";
			twoDoz.Name = "Brown";
			twoDoz.CookieType = "Peanut Butter";
			twoDoz.SpecialDescription = "Sugar-Free";
			twoDoz.Dozens = 2;

			threeDoz.OderNumber = "103";
			threeDoz.Name = "Cooper";
			threeDoz.CookieType = "Sugar";
			threeDoz.SpecialDescription = "Iced";
			threeDoz.Dozens = 3;

			Display(oneDoz);
			Display(twoDoz);
			Display(threeDoz);
		}

		public static void Display(SpecialCookieOrder order)
		{
			WriteLine("Order #{0, -6}\t{1, -15}", order.OderNumber, order.Name);
			WriteLine("\tType: {0}\t{1}", order.SpecialDescription, order.CookieType);
			WriteLine("\t{0} dozen --- ${1}", order.Dozens, order.Price);
		}
	}
}
