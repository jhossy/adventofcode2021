using System;
using System.Collections.Generic;

namespace Day3
{
	internal class Program
	{
		static void Main(string[] args)
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

			Console.ReadLine();
		}
	}
}
