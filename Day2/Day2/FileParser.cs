using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Day2
{
	public class FileParser
	{
		public ShipCourse Parse(string filePath)
		{
			if (!File.Exists(filePath)) return new ShipCourse();

			ShipCourse result = new ShipCourse();

			try
			{
				IEnumerable<string> lines = File.ReadLines(filePath);

				int cnt = lines.ToList().Count;

				foreach (string line in lines)
				{
					if(line.StartsWith("forward", StringComparison.InvariantCultureIgnoreCase))
					{
						int number = int.Parse(line.Substring("forward ".Length));
						result.Course.Add(new SubmarineInput() { Direction = Direction.Forward, Steps = number});
					}

					if (line.StartsWith("down", StringComparison.InvariantCultureIgnoreCase))
					{
						int number = int.Parse(line.Substring("down ".Length));
						//result.Down.Add(number);
						result.Course.Add(new SubmarineInput() { Direction = Direction.Down, Steps = number });
					}

					if (line.StartsWith("up", StringComparison.InvariantCultureIgnoreCase))
					{
						int number = int.Parse(line.Substring("up ".Length));
						result.Course.Add(new SubmarineInput() { Direction = Direction.Up, Steps = number });
					}
				}
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			return result;
		}
	}

	public class ShipCourse
	{
		public List<SubmarineInput> Course { get; set; }

		public ShipCourse()
		{
			Course = new List<SubmarineInput>();
		}
	}
}
