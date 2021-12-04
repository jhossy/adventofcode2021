using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day3
{
	public class SubmarineGenerator
	{
		public List<string> SearchOxygen(List<string> inputValues)
		{
			List<string> tempResult = inputValues;

			int inputLength = inputValues.First().Length;

			int noofZeros = 0;
			int noOfOnes = 0;

			for(int i=0; i < inputLength; i++)
			{
				if (tempResult.Count == 1) return tempResult;

				foreach (string str in tempResult)
				{
					if(str[i] == '0')
					{
						noofZeros++;
					}
					else
					{
						noOfOnes++;
					}
				}

				if(noOfOnes >= noofZeros)
				{
					tempResult = tempResult.Where(x => x[i] == '1').ToList();
				}
				else
				{
					tempResult = tempResult.Where(x => x[i] == '0').ToList();
				}

				noOfOnes = 0;
				noofZeros = 0;
			}

			return tempResult;
		}

		public List<string> SearchC02(List<string> inputValues)
		{
			List<string> tempResult = inputValues;

			int inputLength = inputValues.First().Length;

			int noofZeros = 0;
			int noOfOnes = 0;

			for (int i = 0; i < inputLength; i++)
			{
				if (tempResult.Count == 1) return tempResult;

				foreach (string str in tempResult)
				{
					if (str[i] == '0')
					{
						noofZeros++;
					}
					else
					{
						noOfOnes++;
					}
				}

				if (noOfOnes >= noofZeros)
				{
					tempResult = tempResult.Where(x => x[i] == '0').ToList();
				}
				else
				{
					tempResult = tempResult.Where(x => x[i] == '1').ToList();
				}

				noOfOnes = 0;
				noofZeros = 0;
			}

			return tempResult;
		}
	}
}
