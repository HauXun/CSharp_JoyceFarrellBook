/*
Malcolm Movers charges a base rate of $200 per move plus $150 per hour and $2 per
mile. Write a program named MoveEstimator that prompts a user for and accepts
estimates for the number of hours for a job and the number of miles involved in the
move and displays the total moving fee.
 */



using System;

namespace Exercise_2_9
{
    class MoveEstimator
    {
        static void Main(string[] args)
        {
            const double MOVE_RATE = 200;
            const double HOUR_RATE = 150;
            const double MILE_RATE = 2;
            double inputHours = 0;
            double inputMiles = 0;
            double calculatedEstimate = 0;

            Console.Write("Estimate Hours: $");
            inputHours = double.Parse(Console.ReadLine());
            Console.Write("Estimate Miles: $");
            inputMiles = double.Parse(Console.ReadLine());

            calculatedEstimate = MOVE_RATE + (HOUR_RATE * inputHours) + (MILE_RATE * inputMiles);
            Console.WriteLine("${0} + (${1} * ${2}) + (${3} * ${4})", MOVE_RATE, HOUR_RATE, inputHours, MILE_RATE, inputMiles);
            Console.WriteLine("Estimate the total cost: ${0}", calculatedEstimate);
            Console.Read();
        }
    }
}
