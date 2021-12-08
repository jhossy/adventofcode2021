using System.Collections.Generic;
using System.IO;

namespace Day8
{
	public class FileParser
	{
		public List<FileNote> Parse(string filePath)
		{
			List<FileNote> result = new List<FileNote>();

			if (!File.Exists(filePath)) return result;

			var lines = File.ReadLines(filePath);

			foreach(var line in lines)
			{
				string[] parts = line.Split('|');

				if (parts.Length != 2) continue;

				FileNote fileNote = new FileNote()
				{
					Input = parts[0].Trim(),
					Output = parts[1]
				};

				result.Add(fileNote);
			}

			return result;
		}
	}
}
