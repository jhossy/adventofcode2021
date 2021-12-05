using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Day5
{
	public class FileParser
	{
		public List<Line> Parse(string filePath)
		{
			List<Line> result = new List<Line>();

			if (!File.Exists(filePath)) return result;

			var lines = File.ReadAllLines(filePath);

			foreach(var line in lines)
			{
				string[] lineContent = line.Split("->");

				if(lineContent.Length != 2) continue;

				int[] start = lineContent[0].Split(',').Select(v => int.Parse(v)).ToArray();
				int[] end = lineContent[1].Split(',').Select(v => int.Parse(v)).ToArray();

				Line lineCreated = new Line(new Point(start[0], start[1]), new Point(end[0], end[1]));

				//if(lineCreated.Type == LineType.Diagonal) 
				result.Add(lineCreated);
			}

			return result;
		}
	}
}
