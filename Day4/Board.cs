using System;
using System.Collections.Generic;
using System.Linq;

namespace Day4
{
	public class Board
	{
		public Field[,] Fields { get; private set; }

		public int BoardTotalSum { get; private set; }

		public int BoardMarkedSum { get; private set; }

		public Guid Id { get; }

		public int BoardLength { get; }

		public bool HasWon { get; set; }

		public Board(int x)
		{
			BoardLength = x;
			Id = Guid.NewGuid();
			Fields = new Field[x,x];	
		}

		public void AddBoardLines(List<string> boardLines)
		{
			int line = 0;

			Console.WriteLine($"Board {Id}:");

			foreach(string boardLine in boardLines)
			{
				int[] numbers = boardLine.Split(' ')
					.Where(x => !string.IsNullOrEmpty(x))
					.Select(x => int.Parse(x))
					.ToArray();

				for(int i=0; i < numbers.Length; i++)
				{
					Fields[i, line] = new Field() { Value = numbers[i]};
					BoardTotalSum += numbers[i];
					Console.Write($"{numbers[i]} ");
				}
				Console.WriteLine("");

				line++;
			}

			Console.WriteLine("--------------------------------------");
		}

		public bool CheckBoard()
		{
			return CheckHorizontal() || CheckVertical();
		}

		private bool CheckHorizontal()
		{
			for (int i = 0; i < BoardLength; i++)
			{
				int markedHorizontal = 0;

				for (int j = 0; j < BoardLength; j++)
				{
					if (Fields[j, i].IsMarked)
					{
						markedHorizontal++;
					}
				}

				if (markedHorizontal == 5)
				{
					return true;
				}
			}
			return false;
		}

		private bool CheckVertical()
		{
			for (int i = 0; i < BoardLength; i++)
			{
				int markedVertical = 0;

				for (int j = 0; j < BoardLength; j++)
				{
					if (Fields[i, j].IsMarked)
					{
						markedVertical++;
					}
				}

				if (markedVertical == 5)
				{
					return true;
				}
			}
			return false;
		}

		public bool MarkField(int value)
		{
			Field fieldFound = Search(value);

			if (fieldFound == null) return false;

			fieldFound.IsMarked = true;

			BoardMarkedSum += value;

			Console.WriteLine($"{value} marked on board: {Id}");

			return true;
		}

		internal Field Search(int value)
		{
			for(int i = 0; i < BoardLength; i++)
			{
				for(int j=0; j < BoardLength; j++)
				{
					Field fieldToCheck = Fields[i, j];
					if(fieldToCheck != null && fieldToCheck.Value == value)
					{
						return fieldToCheck;
					}
				}
			}

			return null;
		}
	}
}
