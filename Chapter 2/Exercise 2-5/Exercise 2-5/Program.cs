/*
Write a C# program named InchesToCentmeters that declares a named constant
that holds the number of centimeters in an inch: 2.54. Also declare a variable to
represent a measurement in inches, and assign a value. Display the measurement in
both inches and centimeters—for example, 3 inches is 7.62 centimeters.
 */



using System;

namespace Exercise_2_5
{
    class ProgrInchesToCentmeters
    {
        static void Main(string[] args)
        {
            // Const is used to declare constant variable of any data type

            const double CentimeterInInch = 2.54;

            double inch = 3;

            double centimeter;

            centimeter = inch * CentimeterInInch;

            Console.WriteLine("{0} inches is {1} centimeters.", inch, centimeter);
            Console.Read();
        }
    }
}
