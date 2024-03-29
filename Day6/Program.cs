﻿using System;
using System.Collections.Generic;

namespace Day6
{
	internal partial class Program
	{
		static void Main(string[] args)
		{
			long[] allFish = new long[9];

			FileParser fileParser = new FileParser();
			int[] initialStates = fileParser.Parse("TaskInput.txt");
			//int[] initialStates = fileParser.Parse("DemoInput.txt");
						
			foreach (int state in initialStates)
			{
				allFish[state] += 1;
				Console.WriteLine($"Added {state}");
			}

			long newFish = 0;
			for (int i = 0; i < 256; i++)
			{
				newFish = allFish[0];

				//every day, the timer for each fish decrease by one, i.e. moving it around the array
				allFish[0] = allFish[1];
				allFish[1] = allFish[2];
				allFish[2] = allFish[3];
				allFish[3] = allFish[4];
				allFish[4] = allFish[5];
				allFish[5] = allFish[6];
				//when a fish reaches timer == 0, it spawns a new fish ('newFish')
				allFish[6] = newFish + allFish[7];
				allFish[7] = allFish[8];
				//the newly spawned fish, starts at timer == 8
				allFish[8] = newFish;

				Console.WriteLine($"After day {i}: {allFish[0]}, {allFish[1]}, {allFish[2]}, {allFish[3]}, {allFish[4]}, {allFish[5]}, {allFish[6]}, {allFish[7]}, {allFish[8]}");
			}

			Console.WriteLine(allFish[0] + allFish[1] + allFish[2] + allFish[3] + allFish[4] + allFish[5] + allFish[6] + 
				allFish[7] + allFish[8]);

			Console.ReadLine();
		}
	}
}
