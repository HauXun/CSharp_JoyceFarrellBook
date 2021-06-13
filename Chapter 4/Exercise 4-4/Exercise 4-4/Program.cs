/*
The Saffir-Simpson Hurricane Scale classifies hurricanes into five categories numbered
1 through 5. Write an application named Hurricane that outputs a hurricane’s
category based on the user’s input of the wind speed. Category 5 hurricanes have
sustained winds of at least 157 miles per hour. The minimum sustained wind speeds
for categories 4 through 1 are 130, 111, 96, and 74 miles per hour, respectively. Any
storm with winds of less than 74 miles per hour is not a hurricane.
 */



using System;

namespace Exercise_4_4
{
    class Hurricane
    {
        static void Main(string[] args)
        {
            const byte CategoryHurricanes_5 = 157;
            const byte CategoryHurricanes_4 = 130;
            const byte CategoryHurricanes_3 = 111;
            const byte CategoryHurricanes_2 = 96;
            const byte CategoryHurricanes_1 = 74;

            //Enter the wind speed to evaluate the storm
            Console.Write("Enter the wind speed: ");
            ulong speedWind = ulong.Parse(Console.ReadLine());
            while (speedWind < 1 || speedWind > 32000000)
            {
                if (speedWind > 32000000)
                {
                    Console.WriteLine("The wind speed is greater than the Cosmic Tornado, are you crazy, please re-enter");
                    Console.ReadKey();
                }
                Console.Clear();
                Console.WriteLine("You entered the wrong value, please re-enter it");
                speedWind = ulong.Parse(Console.ReadLine());
            }


            if (speedWind >= CategoryHurricanes_5)
                Console.WriteLine("This is a Category 5 storm with winds of more than 157 miles per hour");
            else if (speedWind >= CategoryHurricanes_4)
                Console.WriteLine("This is a Category 4 storm with winds of more than 130 miles per hour");
            else if (speedWind >= CategoryHurricanes_3)
                Console.WriteLine("This is a Category 3 storm with winds of more than 111 miles per hour");
            else if (speedWind >= CategoryHurricanes_2)
                Console.WriteLine("This is a Category 2 storm with winds of more than 96 miles per hour");
            else if (speedWind >= CategoryHurricanes_1)
                Console.WriteLine("This is a Category 1 storm with winds of more than 74 miles per hour");
            else
                Console.WriteLine("This is not a hurricane !");
            Console.ReadLine();
        }
    }
}
