/*
Create an enumeration named Planet that holds the names for the eight planets in
our solar system, starting with MERCURY and ending with NEPTUNE. Write a program
named Planets that prompts the user for a numeric position, and display the name of
the planet that is in the requested position.
 */



using System;

namespace Exercise_2_17
{
    class Planets
    {
        enum Planet
        {
            Mercury = 1, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune
        }
        static void Main(string[] args)
        {
            Planet myPlanet;
            Console.Write("Enter number of Planet: ");
            int position = int.Parse(Console.ReadLine());
            myPlanet = (Planet)position;
            int valueOfPlanet = (int)myPlanet;
            Console.WriteLine("Value of Planet is: {0}", valueOfPlanet);
            Console.WriteLine("The Planet your entered is {0}", myPlanet);
            Console.ReadLine();
        }
    }
}
