/*
Write an application named EnterUppercaseLetters that asks the user to type an
uppercase letter from the keyboard. If the character entered is an uppercase letter,
display OK; if it is not an uppercase letter, display an error message. The program
continues until the user types an exclamation point.
 */



using System;

namespace Exercise_5_3
{
    class EnterUppercaseLetters
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //string[] upperCaseLetter = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

                string input;
                do
                {
                    Console.Write("Nhap 1 ki tu: ");
                    input = Console.ReadLine();
                } while (input.Length > 1);

                char character = input.ToCharArray()[0];

                int acsiiCode = (int)character;
                Console.WriteLine("Ki tu vua nhap la: {0}", input);

                if (input == "!")
                    break;

                //if (upperCaseLetter.Contains(input))

                if (65 <= acsiiCode && acsiiCode <= 90)
                    Console.WriteLine("OK");
                else
                    Console.WriteLine("Ban phai nhap 1 ki tu in hoa");
            }
            Console.Read();
        }
    }
}
