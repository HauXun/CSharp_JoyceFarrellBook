/*
Create an application named CarDemo that declares at least two Car objects and
demonstrates how they can be incremented using an overloaded ++ operator. Create
a Car class that contains a model and a value for miles per gallon. Include two
overloaded constructors. One accepts parameters for the model and miles per gallon;
the other accepts a model and sets the miles per gallon to 20. Overload a ++ operator
that increases the miles per gallon value by 1. The CarDemo application creates at
least one Car using each constructor and displays the Car values both before and after
incrementation
 */




using System;
using static System.Console;

namespace Exercise_9_5
{
	class CarDemo
	{
		static void Main(string[] args)
		{
			Car c1 = new Car("GT", 25);
			Car c2 = new Car("Mustang");
			Display("GT at beginning", c1);
			Display("GT after prefix increment", ++c1);
			Display("Mustang at beginning", c2);
			Display("Mustang after posfix increment", c2++);
		}

		public static void Display(string message, Car s)
		{
			WriteLine(message);
			WriteLine("\tModel: {0}\tMPG: {1}", s.Model, s.Mpg);
		}
	}
}
