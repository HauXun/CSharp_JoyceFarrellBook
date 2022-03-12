/*
Write an application named DailyTemps that continuously prompts a user for a series
of daily high temperatures until the user enters a sentinel value. Valid temperatures
range from 220 through 130 Fahrenheit. When the user enters a valid temperature,
add it to a total; when the user enters an invalid temperature, display an error message.
Before the program ends, display the number of temperatures entered and the average
temperature.
 */



using System;

namespace Exercise_5_4
{
    class DailyTemps
    {
        static void Main(string[] args)
        {
            const int LIMIT = 999;

            double temperature;
            int count = 0;
            double sum = 0;
            double avg;

            Console.Write("No.{0} Enter a Fahrenheit temperature: ", count);
            temperature = double.Parse(Console.ReadLine());

            while (temperature != LIMIT)
            {
                if (temperature >= 130 && temperature <= 220)
                {
                    sum += temperature;
                    count++;
                }
                else
                {
                    Console.WriteLine("Invalid input. Valid temperatures range from 130 through 220 Fahrenheit. ");
                    Console.WriteLine("Enter 999 to quit.");
                }
                Console.Write("\nNo.{0} Enter a Fahrenheit temperature.: ", count);
                temperature = double.Parse(Console.ReadLine());
            }
            avg = sum / (double)count;
            Console.WriteLine("\nThe number of Fahrenheit temperature entered is {0}°F", count);
            Console.WriteLine("Average Fahrenheit temperature is {0}°F", avg);
            Console.Read();
        }
    }
}
