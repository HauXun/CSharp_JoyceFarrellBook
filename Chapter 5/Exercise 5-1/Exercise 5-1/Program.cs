/*
Write an application named SumFiveInts that allows the user to enter five integers
and displays their sum.
 */



using System;

namespace Exercise_5_1
{
    class SumFiveInts
    {
        static void Main(string[] args)
        {
            int[] integer = new int[5];
            int sum = 0;
            Console.WriteLine("Enter 5 integers...\n");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("No.{0} Enter the integer: ", i + 1);
                integer[i] = int.Parse(Console.ReadLine());
            }
            foreach (var item in integer)
            {
                sum += item;
            }
            Console.WriteLine("\nSum of entered 5 integer numbers is: {0}", sum);
            Console.ReadLine();
        }
    }
}
