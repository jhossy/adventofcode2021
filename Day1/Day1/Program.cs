using System;

namespace Day1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Depth depth = new Depth();
			Depth depth = new FileParser().Parse("Input.txt");

			//depth.AddMeasurement(199);
			//depth.AddMeasurement(200);
			//depth.AddMeasurement(208);
			//depth.AddMeasurement(210);
			//depth.AddMeasurement(200);
			//depth.AddMeasurement(207);
			//depth.AddMeasurement(240);
			//depth.AddMeasurement(269);
			//depth.AddMeasurement(260);
			//depth.AddMeasurement(263);

			depth.CalculateThreeIncrements();

			Console.WriteLine($"Increments: {depth.DepthIncreases}");
		}
	}
}
