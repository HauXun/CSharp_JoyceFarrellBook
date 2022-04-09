/*
In Chapter 4, you wrote a program named Hurricane that classified hurricanes into
five categories using the Saffir-Simpson Hurricane Scale. Now, create a modified
version named HurricaneModularized that passes a user’s input wind speed to a
method that returns the hurricane category
 */



using System;
using static System.Console;

namespace Exercise_7_8
{
	class Hurricane
	{
		const byte CategoryHurricanes_5 = 157;
		const byte CategoryHurricanes_4 = 130;
		const byte CategoryHurricanes_3 = 111;
		const byte CategoryHurricanes_2 = 96;
		const byte CategoryHurricanes_1 = 74;

		public ulong speedWind;
		public string Category;

		public string Modularized()
		{
			if (speedWind >= CategoryHurricanes_5)
				Category = "This is a Category 5 storm with winds of more than 157 miles per hour";
			else if (speedWind >= CategoryHurricanes_4)
				Category = "This is a Category 4 storm with winds of more than 130 miles per hour";
			else if (speedWind >= CategoryHurricanes_3)
				Category = "This is a Category 3 storm with winds of more than 111 miles per hour";
			else if (speedWind >= CategoryHurricanes_2)
				Category = "This is a Category 2 storm with winds of more than 96 miles per hour";
			else if (speedWind >= CategoryHurricanes_1)
				Category = "This is a Category 1 storm with winds of more than 74 miles per hour";
			else
				Category = "This is not a hurricane !";
			return Category;
		}
	}

	class HurricaneModularized
    {
        static void Main(string[] args)
        {
            Hurricane a = new Hurricane();

            //Enter the wind speed to evaluate the storm
            Write("Enter the wind speed: ");
            a.speedWind = ulong.Parse(ReadLine());
            while (a.speedWind < 1 || a.speedWind > 32000000)
            {
                if (a.speedWind > 32000000)
                {
                    WriteLine("The wind speed is greater than the Cosmic Tornado, are you crazy, please re-enter");
                    ReadKey();
                }
                Clear();
                WriteLine("You entered the wrong value, please re-enter it");
                a.speedWind = ulong.Parse(ReadLine());
            }

            string Category = a.Modularized();
            WriteLine(Category);
        }
    }
}
