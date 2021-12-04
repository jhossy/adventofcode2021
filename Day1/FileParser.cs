using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day1
{
	public class FileParser
	{
		public Depth Parse(string filePath)
		{
			Depth depth = new Depth();

			try
			{
				var lines = File.ReadAllLines(filePath);

				foreach(string line in lines)
				{
					depth.AddMeasurement(int.Parse(line));
				}

			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			return depth;
		}
	}
}
