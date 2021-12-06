using System;
using System.Collections.Generic;

namespace Day6
{
	internal partial class Program
	{
		static void Main(string[] args)
		{
			long[] allFish = new long[9];

			FileParser fileParser = new FileParser();
			//int[] initialStates = fileParser.Parse("TaskInput.txt");
			int[] initialStates = fileParser.Parse("DemoInput.txt");
						
			foreach (int state in initialStates)
			{
				allFish[state] += 1;
				Console.WriteLine($"Added {state}");
			}

			List<long> resetFish = new List<long>();
			for (int i = 1; i < 18; i++)
			{
				if (allFish[0] > 0) resetFish.Add(allFish[0]);

				//every day, the timer for each fish decrease by one, i.e. moving it around the array
				allFish[0] = allFish[1];
				allFish[1] = allFish[2];
				allFish[2] = allFish[3];
				allFish[3] = allFish[4];
				allFish[4] = allFish[5];
				allFish[5] = allFish[6];
				allFish[6] = resetFish.Count + allFish[7];
				allFish[7] = allFish[8];
				allFish[8] = resetFish.Count;

				resetFish = new List<long>();

				Console.WriteLine($"After day {i}: {allFish[0]}, {allFish[1]}, {allFish[2]}, {allFish[3]}, {allFish[4]}, {allFish[5]}, {allFish[6]}, {allFish[7]}, {allFish[8]}");
			}

			Console.WriteLine(allFish[0] + allFish[1] + allFish[2] + allFish[3] + allFish[4] + allFish[5] + allFish[6] + 
				allFish[7] + allFish[8] + resetFish.Count);

			Console.ReadLine();
		}
	}
}
