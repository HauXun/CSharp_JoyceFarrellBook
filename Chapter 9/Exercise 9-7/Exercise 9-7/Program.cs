/*
Create an application named ShirtDemo that declares several Shirt objects and
includes a display method to which you can pass different numbers of Shirt objects
in successive method calls. The Shirt class contains auto-implemented properties for
a material, color, and size.s
 */




using System;
using static System.Console;

namespace Exercise_9_7
{
	class ShirtDemo
	{
		static void Main(string[] args)
		{
			Shirt s1 = new Shirt();
			Shirt s2 = new Shirt();
			Shirt s3 = new Shirt();
			Shirt s4 = new Shirt();
			Shirt s5 = new Shirt();

			s1.material = "Cotton";
			s1.color = "White";
			s1.size = "L";
			s2.material = "Polyester";
			s2.color = "Green";
			s2.size = "XL";
			s3.material = "Silk";
			s3.color = "Black";
			s3.size = "L";
			s4.material = "Cotton";
			s4.color = "Blue";
			s4.size = "S";
			s5.material = "Polyester";
			s5.color = "Pink";
			s5.size = "M";

			Display(s1, s2, s3);
			WriteLine("\n");
			Display(s1, s2, s3, s4);
			WriteLine("\n");
			Display(s1, s2, s3, s4, s5);
			WriteLine("\n");
		}

		public static void Display(params Shirt[] s)
		{
			WriteLine("{0, -12}{1, -10}{2, -6}", "Material", "Color", "Size");
			foreach (Shirt shirt in s)
			{
				WriteLine("{0, -12}{1, -10}{2, -6}", shirt.material, shirt.color, shirt.size);
			}
		}
	}
}
