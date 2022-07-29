/*
Create a program named PaintingDemo that instantiates an array of eight Room
objects and demonstrates the Room methods. The Room constructor requires
parameters for length, width, and height fields; use a variety of values when
constructing the objects. The Room class also contains a field for wall area of the
Room and number of gallons of paint needed to paint the room. Both of these values
are computed by calling private methods. Include read-only properties to get a
Room’s values. A room is assumed to have four walls, and you do not need to allow for
windows and doors, and you do not need to allow for painting the ceiling. A room
requires one gallon of paint for every 350 square feet (plus an extra gallon for any
square feet greater than 350). In other words, a 12 3 10 room with 9-foot ceilings has
396 square feet of wall space, and so requires two gallons of paint.
 */




using System;
using static System.Console;

namespace Exercise_9_4
{
	class PaintingDemo
	{
		static void Main(string[] args)
		{
			Room[] rooms = new Room[8];
			int length = 8;
			int width = 8;
			int height = 8;

			for (int i = 0; i < rooms.Length; i++)
			{
				rooms[i] = new Room(length, width, height);
				length += 2;
				width += 1;
				if (i % 2 == 1)
					height += 1;
			}

			for (int i = 0; i < rooms.Length; i++)
			{
				WriteLine("For a {0} x {1} x {2} foot room", rooms[i].Length, rooms[i].Width, rooms[i].Height);
				WriteLine("\tTwo walls are {0} long and {1} high", rooms[i].Length, rooms[i].Height);
				WriteLine("\tand the other two walls are {0} long and {1} high", rooms[i].Width, rooms[i].Height);
				WriteLine("\tTotal wall are is {0}, so you need {1} gallons(s) of paint", rooms[i].Area, rooms[i].Gallons);
			}
		}
	}
}
