/*
Write a program named Admission for a college’s admissions office. The user enters
a numeric high school grade point average (for example, 3.2) and an admission
test score. Display the message Accept if the student meets either of the following
requirements:
• A grade point average of 3.0 or higher, and an admission test score of at least 60
• A grade point average of less than 3.0, and an admission test score of at least 80
• If the student does not meet either of the qualification criteria, display Reject.
 */



using System;

namespace Exercise_4_3
{
    class Admission
    {
        static void Main(string[] args)
        {
            const double pointsAverage = 3.0;
            const int scoreAdmission1 = 60;
            const int scoreAdmission2 = 80;

            Console.Write("Enter your GPA: ");
            double GPA = double.Parse(Console.ReadLine());
            Console.Write("Enter your admission score: ");
            double AdmissionScore = double.Parse(Console.ReadLine());

            if (GPA >= pointsAverage && AdmissionScore >= scoreAdmission1)
                Console.WriteLine("You are accepted, Congratulations !");
            else if (GPA < pointsAverage && AdmissionScore >= scoreAdmission2)
                Console.WriteLine("You are accepted, Congratulations !");
            else
                Console.WriteLine("Sorry, you have been rejected !");
            Console.ReadLine();
        }
    }
}
