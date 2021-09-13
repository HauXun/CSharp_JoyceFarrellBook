/*

 */



using System;

namespace Exercise_4_8
{
    class RockPaperScissors
    {
        static void Main(string[] args)
        {
            int rock = 1;
            int scissor = 2;
            int paper = 3;

            int isContinue;
            Random randomNumber = new Random();
            do
            {
                Console.Write("Enter rock, scissor or paper from the keyboard: ");
                string input = input = Console.ReadLine();
                while (input != "rock" && input != "scissor" && input != "paper")
                {
                    Console.Clear();
                    Console.Write("You have to enter 1 of 3 rock, scissor or paper: ");
                    input = Console.ReadLine();
                }

                Console.Clear();
                int ramdomNumber = randomNumber.Next(1, 4);
                string s1;
                if (ramdomNumber == rock)
                {
                    s1 = Convert.ToString(ramdomNumber);
                    s1 = "rock";
                }
                else if (ramdomNumber == scissor)
                {
                    s1 = Convert.ToString(ramdomNumber);
                    s1 = "scissor";
                }
                else if (ramdomNumber == paper)
                {
                    s1 = Convert.ToString(ramdomNumber);
                    s1 = "paper";
                }
                else
                {
                    s1 = Convert.ToString(ramdomNumber);
                    s1 = "undefined";
                }

                if (String.Compare(input, s1, true) == 0)
                    Console.WriteLine("Draw, computer is {0}", s1);
                else if (String.Compare(input, s1, true) > 0)
                    Console.WriteLine("Lose, computer is {0}", s1);
                else
                    Console.WriteLine("Win, computer is {0}", s1);
                Console.ReadKey();
                Console.Write("Do you want continue ? Press 0 if you don't want to: ");
                isContinue = int.Parse(Console.ReadLine());
            } while (isContinue != 0);
            Console.ReadLine();
        }
    }
}
