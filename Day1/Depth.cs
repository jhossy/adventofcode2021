using System.Collections.Generic;

namespace Day1
{
	public class Depth
	{
		public int DepthIncreases = 0;
		private int _latestIncrease = 0;

		public List<int> Measurements { get; private set; }

		public Depth()
		{
			Measurements = new List<int>();
		}

		public void AddMeasurement(int measure)
		{
			Measurements.Add(measure);

			//if(_latestIncrease > 0 && _latestIncrease < measure)
			//{
			//	DepthIncreases++;
			//}

			//_latestIncrease = measure;
		}

		public int CalculateThreeIncrements()
		{
			int increments = 0;

			for(int i = 0; i < (Measurements.Count - 2); i++)
			{
				int tmpSum = Measurements[i] + Measurements[i+1] + Measurements[i+2];

				if(_latestIncrease > 0 && tmpSum > _latestIncrease)
				{
					DepthIncreases++;
				}

				_latestIncrease = tmpSum;
			}

			return increments;
		}
	}
}
