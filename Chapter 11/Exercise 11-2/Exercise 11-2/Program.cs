/*
ArgumentException is an existing class that derives from Exception; you use it when
one or more of a method’s arguments do not fall within an expected range. Create an
application named SwimmingWaterTemperature containing a variable that can hold
a temperature expressed in degrees Fahrenheit. Within the class, create a method that
accepts a parameter for a water temperature and returns true or false, indicating
whether the water temperature is between 70 and 85 degrees and thus comfortable
for swimming. If the temperature is not between 32 and 212 (the freezing and boiling
points of water), it is invalid, and the method should throw an ArgumentException.
In the Main() method, continuously prompt the user for data temperature, pass it
to the method, and then display a message indicating whether the temperature is
comfortable, not comfortable, or invalid
 */




using System;
using static System.Console;

namespace Exercise_11_2
{
	class Program
	{
		static void Main(string[] args)
		{
			const int QUIT = 999;
			int waterTemp;
			bool isConfortable;
			Write("Enter temperature or {0} to quit >> ", QUIT);
			int.TryParse(ReadLine(), out waterTemp);
			while (waterTemp != QUIT)
			{
				try
				{
					isConfortable = CheckComfortable(waterTemp);
					if (isConfortable)
						WriteLine("{0} degrees is comfortable for swimming.", waterTemp);
					else
						WriteLine("{0} degrees is not comfortable for swimming.", waterTemp);
				}
				catch (ArgumentException e)
				{
					WriteLine(e.Message);
					WriteLine("Exception caught.");
				}
				Write("Enter temperature or {0} to quit >> ", QUIT);
				int.TryParse(ReadLine(), out waterTemp);
			}
		}

		public static Boolean CheckComfortable(int temp)
		{
			bool isComfortable = true;
			const int LOW = 32;
			const int HIGH = 212;
			const int LOWCOMFORT = 70;
			const int HIGHCOMFORT = 85;
			if (temp < LOW || temp > HIGH)
				throw (new ArgumentException());
			if (temp < LOWCOMFORT || temp > HIGHCOMFORT)
				isComfortable = false;
			return isComfortable;
		}
	}
}
