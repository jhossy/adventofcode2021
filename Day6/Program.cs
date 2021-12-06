using System;
using System.Collections.Generic;

namespace Day6
{
	internal partial class Program
	{
		static List<LanternFish> _allFish = new List<LanternFish>();

		static void Main(string[] args)
		{
			//AddDemoFish(3);
			//AddDemoFish(4);
			//AddDemoFish(3);
			//AddDemoFish(1);
			//AddDemoFish(2);

			FileParser fileParser = new FileParser();
			int[] initialStates = fileParser.Parse("TaskInput.txt");

			foreach(int i in initialStates)
			{
				AddDemoFish(i);
			}

			for (int i=0; i < 80; i++)
			{
				string timerString = "";
				for(int j = 0; j < _allFish.Count; j++)
				{
					_allFish[j].PassDay();
					timerString += _allFish[j].Timer + ",";
				}
				Console.WriteLine($"After day: {i}: {timerString}");
			}

			Console.WriteLine($"Total fish: {_allFish.Count}");
			Console.ReadLine();
		}

		private static void AddDemoFish(int state)
		{
			LanternFish fish = new LanternFish(state);
			fish.TimerReset += Fish_TimerReset;
			_allFish.Add(fish);
		}

		private static void Fish_TimerReset(object sender, EventArgs e)
		{
			LanternFish newFish = new LanternFish();
			newFish.TimerReset += Fish_TimerReset;

			_allFish.Add(newFish);

			Console.WriteLine("Fish reset timer");
		}
	}
}
