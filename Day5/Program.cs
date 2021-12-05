using System;
using System.Collections.Generic;
using System.Linq;

namespace Day5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			FileParser parser = new FileParser();
			var lines = parser.Parse("Part1Input.txt");
			//var lines = parser.Parse("DemoInput.txt");

			List<Point> intersections = new List<Point>();
			foreach(Line line in lines)
			{
				Console.WriteLine(line);
				foreach (Line otherline in lines)
				{
					if (line.Id == otherline.Id) continue;

					var tmpIntersections = line.IntersectWith(otherline);

					if (tmpIntersections.Any())
					{
						intersections.AddRange(tmpIntersections);
					}
				}
			}

			Console.WriteLine($"IntersectionCount: {intersections.Distinct(new PointComparer()).Count()}");

			Console.ReadLine();
		}

		private static void Part1(List<Line> lines)
		{
			List<Point> intersections = new List<Point>();
			foreach (Line line in lines)
			{
				//Console.WriteLine(line.ToString());

				foreach (Line otherline in lines)
				{
					if (line.Id == otherline.Id) continue;

					var tmpIntersections = line.IntersectWith(otherline);

					if (tmpIntersections.Any())
					{
						intersections.AddRange(tmpIntersections);
					}
				}
			}

			//Intersections are counted twice - one for each line
			Console.WriteLine($"IntersectionCount: {intersections.Distinct(new PointComparer()).Count()}");
		}
	}
}
