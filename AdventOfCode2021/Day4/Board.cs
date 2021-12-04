using System.Collections.Generic;

namespace Day4
{
	public class Board
	{
		public Field[,] Fields { get; private set; }

		public Board(int x)
		{
			Fields = new Field[x,x];	
		}

		public void AddBoardLines(int[][] numbers)
		{
			for(int i = 0; i < numbers.Length; i++)
			{
				for(int j = 0; j < numbers.Length; j++)
				{
					Fields[i, j] = new Field() { Value = numbers[i][j] };
				}
			}
		}

		public void MarkField(int value)
		{
			Field fieldFound = Search(value);

			if (fieldFound == null) return;

			fieldFound.IsMarked = true;
		}

		internal Field Search(int value)
		{
			for(int i = 0; i < Fields.Length; i++)
			{
				for(int j=0; j < Fields.Length; j++)
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
