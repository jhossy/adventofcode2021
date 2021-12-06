using System.IO;
using System.Linq;

namespace Day6
{
	internal partial class Program
	{
		public class FileParser
		{
			public int[] Parse(string filePath)
			{
				if (!File.Exists(filePath)) return new int[0];

				var lines = File.ReadLines(filePath).ToList();

				return lines[0].Split(',').Select(x => int.Parse(x)).ToArray();
			}
		}
	}
}
