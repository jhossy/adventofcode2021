using System;
using System.IO;
using System.Linq;

namespace Day9
{
	internal class Program
	{
		static void Main(string[] args)
		{
			FileParser fileParser = new FileParser();
			fileParser.Parse("DemoInput.txt");

			Console.WriteLine("Hello World!");
		}
	}

	public class FileParser
	{
		public int[,] Parse(string filePath)
		{
			int[,] map = new int[0,0];

			if (!File.Exists(filePath)) return map;

			var lines = File.ReadLines(filePath);

			int width = lines.First().Length;
			int height = lines.Count();
			map = new int[height, width];

			int j = 0;
			foreach (var line in lines)
			{
				for (int i = 0; i < line.Length; i++)
				{
					map[j, i] = int.Parse(line[i].ToString());
				}
				j++;
			}

			return map;
		}
	}
}
