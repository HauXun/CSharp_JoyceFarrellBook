/*
Write a C# program named ProjectedRaises that includes a named constant
representing next year’s anticipated 4 percent raise for each employee in a company. Also
declare variables to represent the current salaries for three employees. Assign values to
the variables, and display, with explanatory text, next year’s salary for each employee.
 */



using System;

namespace Exercise_2_7
{
    class ProjectedRaises
    {
        static void Main(string[] args)
        {
            const double salaryIncrement = 0.04d;
            double staff1 = 25000;
            double staff2 = 38000;
            double staff3 = 51000;
            String.Format("{0:n1}", 25000);
            Console.WriteLine("Next year's salary for the first staff will be $" + (staff1 + (staff1 * salaryIncrement)).ToString("0.00"));
            Console.WriteLine("Next year's salary for the second staff will be $" + (staff2 + (staff2 * salaryIncrement)).ToString("0.00"));
            Console.WriteLine("Next year's salary for the third staff will be $" + (staff3 + (staff3 * salaryIncrement)).ToString("0.00"));
            Console.ReadLine();
        }
    }
}
