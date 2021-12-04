using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day4
{
	public class FileParser
	{
		public GameInput Parse(string fileName)
		{
			GameInput gameInput = new GameInput();

			if (!File.Exists(fileName)) return gameInput;

			IEnumerable<string> rawInput = File.ReadLines(fileName);
			
			int i = 0;

			Board b = null;

			foreach (string input in rawInput)
			{
				if(i == 0)
				{
					gameInput.Numbers = input
						.Split(',')
						.Select(x => int.Parse(x))
						.ToArray();

					i++;

					continue;
				}

				if (string.IsNullOrEmpty(input))
				{
					b = new Board(input.Length);	
					
					if(b.Fields.Length > 0)
					{
						gameInput.RawBoards.Add(b);
					}
					continue;
				}

				var boardLine = input
					.Split(' ')
					.Where(x => !string.IsNullOrEmpty(x))
					.Select(x => int.Parse(x))
					.ToArray();

				//b.AddBoardLine(boardLine);

				i++;
			}

			return gameInput;
		}
	}
}
