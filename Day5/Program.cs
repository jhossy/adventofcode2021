using System;
using System.Linq;

namespace Day5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var x = Enumerable.Range(1, 1);

			Point start = new Point(3, 0);

			Point end = new Point(3, 7);

			Line l = new Line(start, end);

			foreach(Point p in l.Points)
			{
				Console.WriteLine($"({p.X}, {p.Y})");
			}

			Console.ReadLine();
		}
	}
}
