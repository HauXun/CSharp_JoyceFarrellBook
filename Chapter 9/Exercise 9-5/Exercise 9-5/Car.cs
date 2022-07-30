using System;

namespace Exercise_9_5
{
	class Car
	{
		public string Model { get; set; }
		public double Mpg { get; set; }
		public static Car operator ++(Car c)
		{
			++c.Mpg;
			return c;
		}

		public Car(string model, double mpg)
		{
			Model = model;
			Mpg = mpg;
		}

		public Car(string name) : this(name, 20)
		{

		}
	}
}
