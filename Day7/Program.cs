using System;
using System.IO;
using System.Linq;

namespace Day7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			FileParser parser = new FileParser();

			//int[] puzzleInput = parser.Parse("DemoInput.txt");
			int[] puzzleInput = parser.Parse("Task1Input.txt");

			int maxValue = puzzleInput.Max();
			int minValue = puzzleInput.Min();

			int lowestFuelCost = int.MaxValue;
			int tmpFuelCost = 0;
			for (int j = minValue; j < maxValue; j++)
			{
				tmpFuelCost = 0;
				for (int i = 0; i < puzzleInput.Length; i++)
				{
					tmpFuelCost += Math.Abs(puzzleInput[i] - j);
				}

				if(tmpFuelCost < lowestFuelCost)
				{
					lowestFuelCost = tmpFuelCost;	
				}
			}				

			Console.WriteLine($"Max: {maxValue} - Min:{minValue} - LowestFuelCost: {lowestFuelCost}");
			Console.ReadLine();
		}
	}

	public class FileParser
	{
		public int[] Parse(string filePath)
		{
			if (!File.Exists(filePath)) return new int[0];

			var lines = File.ReadAllText(filePath);

			return lines.Split(new char[] { ',' }).Select(x => int.Parse(x)).ToArray();
		}
	}
}
