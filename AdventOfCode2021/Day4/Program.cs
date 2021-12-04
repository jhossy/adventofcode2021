using System;

namespace Day4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			FileParser fileParser = new FileParser();

			GameInput input = fileParser.Parse("Part1Input.txt");

			Console.WriteLine("Hello World!");
		}
	}
}
