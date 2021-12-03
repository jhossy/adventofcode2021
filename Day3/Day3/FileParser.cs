using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Day3
{
	public class FileParser
	{
		public List<string> Parse(string filePath)
		{
			if (!File.Exists(filePath)) return new List<string>();

			return File.ReadLines(filePath).ToList();
		}
	}
}
