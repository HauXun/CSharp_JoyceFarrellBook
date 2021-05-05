/*
Write a program named TestsInteractive that prompts a user for eight test scores and
displays the average of the test scores to two decimal places.
 */



using System;

namespace Exercise_2_14
{
    class TestsInteractive
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first test score: ");
            double firstTestScore = double.Parse(Console.ReadLine());
            Console.Write("Enter your second test score: ");
            double secondTestScore = double.Parse(Console.ReadLine());
            Console.Write("Enter your third test score: ");
            double thirdTestScore = double.Parse(Console.ReadLine());
            Console.Write("Enter your forth test score: ");
            double forthTestScore = double.Parse(Console.ReadLine());
            Console.Write("Enter your fifth test score: ");
            double fifthTestScore = double.Parse(Console.ReadLine());
            Console.Write("Enter your sixth test score: ");
            double sixthTestScore = double.Parse(Console.ReadLine());
            Console.Write("Enter your seventh test score: ");
            double seventhTestScore = double.Parse(Console.ReadLine());
            Console.Write("Enter your eighth test score: ");
            double eighthTestScore = double.Parse(Console.ReadLine());

            double everages = (firstTestScore + secondTestScore + thirdTestScore + forthTestScore + fifthTestScore + sixthTestScore + seventhTestScore + eighthTestScore) / 8;
            Console.WriteLine("Your everages score is {0:N2}", everages);
            Console.Read();
        }
    }
}
