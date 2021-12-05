using System.Collections.Generic;
using System.Linq;

namespace Day5
{
	public class Line
	{
		public Point Start { get; set; }

		public Point End { get; set; }

		public List<Point> Points { get; set; }

		public LineType Type { get; set; }

		public Line(Point start, Point end)
		{
			Start = start;
			End = end;
			Points = new List<Point>();

			Init();
		}

		public void Init()
		{
			List<int> possibleX = new List<int>();
			List<int> possibleY = new List<int>();

			if (Start.X == End.X)
			{
				possibleX.Add(Start.X);
				possibleY = Enumerable.Range(Start.Y, End.Y + 1).ToList();				
			}
			else
			{
				possibleY.Add(Start.Y);
				possibleX = Enumerable.Range(Start.X, End.X + 1).ToList();
			}

			if(possibleX.Count == 1)
			{
				foreach(int yCoord in possibleY)
				{
					Points.Add(new Point(possibleX[0], yCoord));
				}

				Type = LineType.Horizontal;
			}
			else
			{
				foreach (int xCoord in possibleX)
				{
					Points.Add(new Point(xCoord, possibleY[0]));
				}

				Type = LineType.Vertical;
			}
		}
	}
}
