/*
Danielle, Edward, and Francis are three salespeople at Holiday Homes. Write an
application named HomeSales that prompts the user for a salesperson initial (D, E,
or F ). Either uppercase or lowercase initials are valid. While the user does not type Z,
continue by prompting for the amount of a sale. Issue an error message for any invalid
initials entered. Keep a running total of the amounts sold by each salesperson. After
the user types Z or z for an initial, display each salesperson’s total, a grand total for all
sales, and the name of the salesperson with the highest total.
 */



using System;
using System.Globalization;
using static System.Console;

namespace Exercise_5_5
{
    class HomeSales
    {
        static void Main()
        {
            string sentinel = "";

            double dSale = 0;
            double eSale = 0;
            double fSale = 0;

            double total;

            // Iterates till the user entered sentinel is z
            while (sentinel != "Z")
            {
                do
                {
                    WriteLine("\n --- Enter Z or z to stop program ---");
                    Write("Enter the abbreviation of the seller (D, E, or F): ");
                    sentinel = ReadLine().ToUpper();
                    if (sentinel.Length > 1)
                        WriteLine("\nYou must enter a character...");
                } while (sentinel.Length > 1);


                switch (sentinel)
                {
                    // Get sale amount from user
                    case "D":
                        WriteLine("\nYou have entered Danielle's name");
                        Write("Amount of Sale: ");
                        dSale += double.Parse(ReadLine());
                        break;
                    case "E":
                        WriteLine("\nYou have entered Edward's name");
                        Write("Amount of Sale: ");
                        eSale += double.Parse(ReadLine());
                        break;
                    case "F":
                        WriteLine("\nYou have entered Francis's name");
                        Write("Amount of Sale: ");
                        fSale += double.Parse(ReadLine());
                        break;
                    default:
                        if (sentinel != "Z")
                        {
                            WriteLine("\nSorry - Invalid Salesperson. \nYou must enter the seller's initials (D, E or F) \nPress anykey to continue...!");
                            ReadKey();
                        }
                        break;
                }
            }
            // calculationg total amount
            total = dSale + eSale + fSale;

            WriteLine("\nDanielle sold: {0}", dSale.ToString("c", CultureInfo.GetCultureInfo("en-US")));
            WriteLine("Edward sold: {0}", eSale.ToString("c", CultureInfo.GetCultureInfo("en-US")));
            WriteLine("Francis sold: {0}", fSale.ToString("c", CultureInfo.GetCultureInfo("en-US")));
            WriteLine("Total sales were: {0}", total.ToString("c", CultureInfo.GetCultureInfo("en-US")));

            // Find out who sells the most
            if (dSale > eSale && dSale > fSale)
                WriteLine("\nDanielle sold the most !");
            else if (fSale > dSale && fSale > eSale)
                WriteLine("\nFrancis sold the most !");
            else
                WriteLine("\nEdward sold the most !");

            // -- Test code --
            //CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // Try with "en-US"
            //string a = double.Parse("123").ToString("#,###.00");
            //Console.WriteLine(a);
        }
    }
}
