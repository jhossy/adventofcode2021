using System;
using System.Collections.Generic;
using System.Linq;

namespace Day8
{
	internal partial class Program
	{
		static void Main(string[] args)
		{
			FileParser fileParser = new FileParser();

			List<FileNote> res = fileParser.Parse("TaskInput.txt");
			
			PuzzleSolver solver = new PuzzleSolver();

			Digit d = new Digit();

			List<MappedValue> values = new List<MappedValue>();

			int runningTotal = 0;
			foreach (FileNote note in res)
			{
				values = new List<MappedValue>();

				foreach (string str in note.InputArr.OrderBy(aux => aux.Length).ToArray())
				{
					values.Add(solver.Solve(d, str));
				}

				string runningResult = "";
				foreach (string str in note.Output.TrimStart().Split(' '))
				{
					string sorted = string.Concat(str.OrderBy(c => c));

					MappedValue elm = values.FirstOrDefault(x => x.Input == sorted);
					
					runningResult += elm.Value;
				}
				
				Console.WriteLine(int.Parse(runningResult));

				runningTotal += int.Parse(runningResult);
			}

			Console.WriteLine($"Total: {runningTotal}");
			Console.ReadLine();
		}		

		private static void Part1()
		{
			Dictionary<string, string> mappings = new Dictionary<string, string>()
			{
				{"0","abcefg"},
				{"1","cf"},
				{"2","acdeg"},
				{"3","acdfg"},
				{"4","bcdf"},
				{"5","abdfg"},
				{"6","abdefg"},
				{"7","acf"},
				{"8","abcdefg"},
				{"9","abcdfg"}
			};

			FileParser fileParser = new FileParser();

			//List<FileNote> res = fileParser.Parse("DemoInput.txt");
			List<FileNote> res = fileParser.Parse("TaskInput.txt");

			int sum = 0;
			foreach (FileNote note in res)
			{
				string[] outputParts = note.Output.Split(' ');

				foreach (string part in outputParts)
				{
					if (part.Length == mappings["1"].Length ||
						part.Length == mappings["4"].Length ||
						part.Length == mappings["7"].Length ||
						part.Length == mappings["8"].Length)
					{
						sum++;
					}
				}
			}

			Console.WriteLine(sum);
		}
	}
}
