/*
Convert the InchesToCentimeters program to an interactive application named
InchesToCentimeterslnteractive. Instead of assigning a value to the inches variable,
accept the value from the user as input.
 */



using System;

namespace Exercise_2_6
{
    class InchesToCentimeterslnteractive
    {
        static void Main(string[] args)
        {
            const double CentimeterInInch = 2.54;

            Console.Write("Enter the number of inches you want: ");
            double inch = double.Parse(Console.ReadLine());

            double centimeter;

            centimeter = inch * CentimeterInInch;

            Console.WriteLine("{0} inches is {1} centimeters.", inch, centimeter);
            Console.Read();
        }
    }
}
