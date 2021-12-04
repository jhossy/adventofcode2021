using System;

namespace Day2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			SubMarine subMarine = new SubMarine();

			//subMarine.MoveForward(5);
			//subMarine.MoveDown(5);
			//subMarine.MoveForward(8);
			//subMarine.MoveUp(3);
			//subMarine.MoveDown(8);
			//subMarine.MoveForward(2);

			FileParser fileParser = new FileParser();
			ShipCourse course = fileParser.Parse("Input.txt");

			foreach (var direction in course.Course)
			{
				if(direction.Direction == Direction.Forward)
				{
					subMarine.MoveForward(direction.Steps);
				}

				if(direction.Direction == Direction.Up)
				{
					subMarine.MoveUp(direction.Steps);
				}

				if (direction.Direction == Direction.Down)
				{
					subMarine.MoveDown(direction.Steps);
				}
			}

			Console.WriteLine($"Final pos: Horizontal:{subMarine.HorizontalPosition()} Depth: {subMarine.Depth}");
			Console.ReadLine();
		}
	}
}
