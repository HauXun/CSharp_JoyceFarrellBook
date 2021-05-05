/*
Convert the ProjectedRaises class to an interactive application named
ProjectedRaisesInteractive. Instead of assigning values to the salaries, accept them
from the user as input.
 */



using System;

namespace Exercise_2_8
{
    class ProjectedRaisesInteractive
    {
        static void Main(string[] args)
        {
            const double salaryIncrement = 0.04d;

            Console.Write("Enter the employee's salary: ");
            double employee1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the employee's salary: ");
            double employee2 = double.Parse(Console.ReadLine());

            Console.Write("Enter the employee's salary: ");
            double employee3 = double.Parse(Console.ReadLine());

            String.Format("{0:n1}", 25000);

            Console.WriteLine("Next year's salary for the first employee will be $" + (employee1 + (employee1 * salaryIncrement)).ToString("0.00"));
            Console.WriteLine("Next year's salary for the second employee will be $" + (employee2 + (employee2 * salaryIncrement)).ToString("0.00"));
            Console.WriteLine("Next year's salary for the third employee will be $" + (employee3 + (employee3 * salaryIncrement)).ToString("0.00"));
            Console.ReadLine();
        }
    }
}
