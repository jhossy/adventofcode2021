using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day4
{
	public class FileParser
	{
		private int boardLength = 5;

		public GameInput Parse(string fileName)
		{
			GameInput gameInput = new GameInput();

			if (!File.Exists(fileName)) return gameInput;

			IEnumerable<string> rawInput = File.ReadLines(fileName);
			
			int i = 0;
			Board b = null;

			List<string> lines = new List<string>();

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

				if (!string.IsNullOrEmpty(input))
				{
					lines.Add(input);
				}

				if (lines.Count == boardLength)
				{
					b = new Board(boardLength);	
					
					b.AddBoardLines(lines);

					if(b.Fields.Length > 0 && b.BoardTotalSum > 0)
					{
						gameInput.RawBoards.Add(b);
					}

					lines = new List<string>();
					continue;
				}
				
				i++;
			}

			return gameInput;
		}
	}
}
