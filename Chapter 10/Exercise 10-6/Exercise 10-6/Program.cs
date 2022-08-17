/*
Create an application named ShapesDemo that creates several objects that descend
from an abstract class called GeometricFigure. Each GeometricFigure includes
a height, a width, and an area. Provide get and set accessors for each field except
area; the area is computed and is read-only. Include an abstract method called
ComputeArea() that computes the area of the GeometricFigure. Create three
additional classes:
• A Rectangle is a GeometricFigure whose area is determined by multiplying
width by height.
• A Square is a Rectangle in which the width and height are the same. Provide a
constructor that accepts both height and width, forcing them to be equal if they
are not. Provide a second constructor that accepts just one dimension and uses it
for both height and width. The Square class uses the Rectangle’s ComputeArea()
method.
• A Triangle is a GeometricFigure whose area is determined by multiplying the
width by half the height.
In the ShapesDemo class, after each object is created, pass it to a method that accepts
a GeometricFigure argument in which the figure’s data is displayed. Change some
dimensions of some of the figures, and pass each to the display method again.
 */





using System;
using static System.Console;

namespace Exercise_10_6
{
	class ShapeDemo
	{
		static void Main(string[] args)
		{
			Rectangle r1 = new Rectangle(3, 4);
			DisplayShapeStatistics(r1);
			Square s1 = new Square(3, 4);
			DisplayShapeStatistics(s1);
			s1.Height = 20;
			DisplayShapeStatistics(s1);
			Square s2 = new Square(6);
			DisplayShapeStatistics(s2);
			s2.Width = 20;
			DisplayShapeStatistics(s2);
			Triangle t1 = new Triangle(3, 4);
			DisplayShapeStatistics(t1);
			t1.Height = 20;
			DisplayShapeStatistics(t1);
		}

		static void DisplayShapeStatistics(GeometricFigure g)
		{
			WriteLine(g.GetType() + " Height: " + g.Height + " Width: " + g.Width + " Area: " + g.Area);
		}
	}
}
