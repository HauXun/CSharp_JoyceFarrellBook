using System;

namespace Exercise_9_4
{
	class Room
	{
		int width, height, length, area, gallons;
		public Room(int length, int width, int height)
		{
			this.length = length;
			this.width = width;
			this.height = height;
			ComputerArea();
			ComputerGallons();
		}

		public double Length
		{
			get => length;
		}

		public int Width
		{
			get => width;
		}

		public int Height
		{
			get => height;
		}

		public int Area
		{
			get => area;
		}

		public int Gallons
		{
			get => gallons;
		}

		void ComputerArea()
		{
			area = length * height * 2 + width * height * 2;
		}

		void ComputerGallons()
		{
			const int GAL_PER_SQ_FT = 350;
			gallons = area / GAL_PER_SQ_FT;
			if (area % GAL_PER_SQ_FT != 0)
				gallons++;
		}
	}
}
