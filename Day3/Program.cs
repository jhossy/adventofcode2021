using System;
using System.Collections.Generic;
using System.Linq;

namespace Day3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//List<string> list = new List<string>() { "00100", "11110", "10110", "10111", "10101", "01111", "00111", "11100", "10000", "11001", "00010", "01010"};

			FileParser fileParser = new FileParser();

			List<string> list = fileParser.Parse("Input.txt");

			SubmarineGenerator generator = new SubmarineGenerator();

			var oxygenRaw = generator.SearchOxygen(list);
			
			int oxygen = Convert.ToInt32(oxygenRaw.First(), 2);

			var co2Raw = generator.SearchC02(list);

			int co2 = Convert.ToInt32(co2Raw.First(), 2);

			Console.WriteLine($"oxygenRaw: {oxygenRaw[0]} - oxygen: {oxygen}");

			Console.WriteLine($"co2Raw: {co2Raw[0]} - co2: {co2}");

			Console.ReadLine();
		}

		static void Part1()
		{
			//List<string> list = new List<string>() { "00100", "11110", "10110", "10111", "10101", "01111", "00111", "11100", "10000", "11001", "00010", "01010"};

			FileParser fileParser = new FileParser();

			List<string> list = fileParser.Parse("Input.txt");

			BinaryConverter bc = new BinaryConverter();

			string gammaRaw = bc.CalculateGamma(list);

			string epsilonRaw = bc.CalculateEpsilon(list);

			int gamma = Convert.ToInt32(gammaRaw, 2);

			int epsilon = Convert.ToInt32(epsilonRaw, 2);

			Console.WriteLine($"GammaRaw: {gammaRaw} - EpsilonRaw: {epsilonRaw}");

			Console.WriteLine($"Gamma: {gamma} - Epsilon: {epsilon}");
		}
	}
}
