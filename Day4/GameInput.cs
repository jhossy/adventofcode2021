using System.Collections.Generic;

namespace Day4
{
	public class GameInput
	{
		public int[] Numbers { get; set; }

		public List<Board> RawBoards { get; set; }

		public GameInput()
		{
			Numbers = new int[0];
			RawBoards = new List<Board>();
		}
	}
}
