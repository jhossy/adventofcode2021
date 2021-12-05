using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace Day5
{
	public class Line
	{
		public Guid Id { get; }

		public Point Start { get; set; }

		public Point End { get; set; }

		public List<Point> Points { get; set; }

		public LineType Type { get; set; }

		public Line(Point start, Point end)
		{
			Id = Guid.NewGuid();
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
				possibleY = Enumerable.Range(Math.Min(Start.Y, End.Y), Math.Abs(Start.Y - End.Y) + 1).ToList();				
			}
			else if(Start.Y == End.Y)
			{
				possibleY.Add(Start.Y);
				possibleX = Enumerable.Range(Math.Min(Start.X, End.X), Math.Abs(Start.X - End.X) + 1).ToList();
			}			

			if(possibleX.Count == 1)
			{
				foreach(int yCoord in possibleY)
				{
					Points.Add(new Point(possibleX[0], yCoord));
				}

				Type = LineType.Vertical;
			}
			else if(possibleY.Count == 1)
			{
				foreach (int xCoord in possibleX)
				{
					Points.Add(new Point(xCoord, possibleY[0]));
				}

				Type = LineType.Horizontal;
			}
			else
			{
				Console.WriteLine($"Start: {Start} - End: {End}");

				for (int i = 0; i < Math.Abs(Start.X - End.X) + 1; i++)
				{
					//5,5 -> 8,2 : 5,5|6,4|7,3|8,2
					if (Start.X > End.X && Start.Y > End.Y) 
					{ 
						Point p = new Point(Start.X - i, Start.Y - i);
						Points.Add(p);
					}
					else if(Start.X > End.X && Start.Y < End.Y)
					{
						Point p = new Point(Start.X - i, Start.Y + i);
						Points.Add(p);
					}
					else if(Start.X < End.X && Start.Y > End.Y)
					{
						Point p = new Point(Start.X + i, Start.Y - i);
						Points.Add(p);
					}
					else
					{
						Point p = new Point(Start.X + i, Start.Y + i);
						Points.Add(p);
					}
				}

				Type = LineType.Diagonal;
			}
		}

		public List<Point> IntersectWith(Line otherline)
		{
			List<Point> intersectionPoints = new List<Point>();

			if (otherline == null || Id == otherline.Id) return intersectionPoints;

			foreach (Point p in Points)
			{
				Point intersectingPoint = otherline.Points.FirstOrDefault(point => point.X == p.X && point.Y == p.Y);
				if (intersectingPoint != null) 
				{
					Console.WriteLine($"{p} intersects with {intersectingPoint}");
					intersectionPoints.Add(intersectingPoint);
				}				
			}

			return intersectionPoints;
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			
			foreach(Point point in Points)
			{
				sb.Append(point.ToString() + " ");
			}

			return sb.ToString();
		}
	}
}
