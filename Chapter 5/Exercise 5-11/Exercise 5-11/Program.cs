/*
In a “You Do It” section of this chapter, you created a tipping table for patrons to
use when analyzing their restaurant bills. Now, create a modified program named
TippingTable3 in which each of the following values is obtained from user input:
• The lowest tipping percentage
• The highest tipping percentage
• The lowest possible restaurant bill
• The highest restaurant bill
 */



using System;
using static System.Console;

namespace Exercise_5_11
{
    class TippingTable3
    {
        static void Main(string[] args)
        {
            double dinnerPrice;
            double tipRate;
            double tip;
            double lowRate;
            double highRate;
            double highDinner;
            double lowDinner;
            const double TIPSTEP = 0.05;
            const double DINNERSTEP = 10.00;

            // The lowest tipping percentage
            Write("Enter the lowest tipping rate (in decimal form (ex. 5% = 0.05): ");
            lowRate = double.Parse(ReadLine());
            // The highest tipping percentage
            Write("Enter the highest tipping rate (in decimal form (ex. 25% = 0.25): ");
            highRate = double.Parse(ReadLine());
            // The lowest possible restaurant bill
            Write("Enter the lowest bill: $");
            lowDinner = double.Parse(ReadLine());
            // The highest restaurant bill
            Write("Enter the highest bill: $");
            highDinner = double.Parse(ReadLine());


            Write("   Price");
            for (tipRate = lowRate; tipRate <= highRate; tipRate += TIPSTEP)
                Write("{0, 8}", tipRate.ToString("F"));
            WriteLine();
            for (int x = 0; x < 40; ++x)
                Write("-");
            WriteLine();
            tipRate = lowRate;
            dinnerPrice = lowDinner;

            while (dinnerPrice <= highDinner)
            {
                Write("{0, 8}", dinnerPrice.ToString("C"));
                while (tipRate <= highRate)
                {
                    tip = dinnerPrice * tipRate;
                    Write("{0, 8}", tip.ToString("F"));
                    tipRate += TIPSTEP;
                }
                dinnerPrice += DINNERSTEP;
                tipRate = lowRate;
                WriteLine();
            }
        }
    }
}
