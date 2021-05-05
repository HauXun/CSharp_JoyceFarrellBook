/*
Write a program named FahrenheitToCelsius that accepts a temperature in
Fahrenheit from a user and converts it to Celsius by subtracting 32 from the Fahrenheit
value and multiplying the result by 5/9. Display both values to one decimal place.
 */



using System;

namespace Exercise_2_15
{
    class FahrenheitToC
    {
        static void Main(string[] args)
        {
            double Celsius;
            Console.Write("Enter the Fahrenheit Temperature: ");
            double Fahrenheit = double.Parse(Console.ReadLine());
            Celsius = (Fahrenheit - 32) * 5 / 9;
            Console.WriteLine("The Converted Celsius Temperature is: {0:n1}", Celsius);
            Console.ReadLine();
        }
    }
}
