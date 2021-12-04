using System;
using System.Collections.Generic;
using System.Linq;

namespace Day4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Board> BoardsWhoWon = new List<Board>();

			FileParser fileParser = new FileParser();

			GameInput input = fileParser.Parse("Task1Input.txt");
			//GameInput input = fileParser.Parse("DemoInput.txt");

			int iterator = 0;
			foreach(int number in input.Numbers)
			{
				foreach(Board b in input.RawBoards.Where(b => !b.HasWon))
				{
					bool markedField = b.MarkField(number);

					if (iterator >= 5)
					{
						bool hasWon = b.CheckBoard();

						if (hasWon)
						{
							b.HasWon = true;

							Console.WriteLine($"Board with id: {b.Id} won with number: {number}. Board sum: {b.BoardTotalSum - b.BoardMarkedSum}");
							Console.WriteLine($"Final score: {number * (b.BoardTotalSum - b.BoardMarkedSum)}");
						}
					}					
				}

				iterator++;
			}

			Console.WriteLine("Hello World!");
		}
	}
}
