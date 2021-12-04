using System.Collections.Generic;
using System.Linq;

namespace Day2
{
	public class SubmarineInput
	{
		public int Steps { get; set; }

		public Direction Direction { get; set; }
	}

	public enum Direction
	{
		Forward,
		Up,
		Down
	}

	public class SubMarine
	{
		List<SubmarineInput> Position = new List<SubmarineInput>();

		public int Depth { get; set; }

		public int Aim { get; set; }

		public void MoveForward(int pos)
		{
			Position.Add(new SubmarineInput() { Direction = Direction.Forward, Steps = pos});
			Depth += pos * Aim;
		}

		public void MoveDown(int pos)
		{
			Aim += pos;
			Position.Add(new SubmarineInput() { Direction = Direction.Down, Steps = pos});
		}

		public void MoveUp(int pos)
		{
			Aim -= pos;
			Position.Add(new SubmarineInput() { Direction = Direction.Up, Steps = -1 * pos });			
		}

		public int HorizontalPosition()
		{
			return Position.Where(x => x.Direction == Direction.Forward).Sum(x => x.Steps);
		}

		//public int DepthPosition()
		//{
		//	return _down.Sum() + _up.Sum();
		//}
	}
}
