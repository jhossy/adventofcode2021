using System.Collections.Generic;
using System.Linq;

namespace Day3
{
	public class BinaryConverter
	{
		public string CalculateGamma(List<string> inputValues)
		{
			int inputLength = inputValues.First().Length;

			int noOfOnes = 0;
			int noOfZeros = 0;

			string result = string.Empty;

			for (int i = 0; i < inputLength; i++)
			{
				foreach (string str in inputValues)
				{
					if (str[i] == '0')
					{
						noOfZeros++;
					}
					else
					{
						noOfOnes++;
					}
				}

				if(noOfOnes > noOfZeros)
				{
					result += "1";
				}
				else
				{
					result += "0";
				}

				noOfOnes = 0;
				noOfZeros = 0;
			}

			return result;
		}

		public string CalculateEpsilon(List<string> inputValues)
		{
			int inputLength = inputValues.First().Length;

			int noOfOnes = 0;
			int noOfZeros = 0;

			string result = string.Empty;

			for (int i = 0; i < inputLength; i++)
			{
				foreach (string str in inputValues)
				{
					if (str[i] == '0')
					{
						noOfZeros++;
					}
					else
					{
						noOfOnes++;
					}
				}

				if (noOfOnes > noOfZeros)
				{
					result += "0";
				}
				else
				{
					result += "1";
				}

				noOfOnes = 0;
				noOfZeros = 0;
			}

			return result;
		}

		private string CalculateFirstEpsilonDigit(List<string> inputValues)
		{
			string result = string.Empty;

			int noOfOnes = 0;
			int noOfZeros = 0;

			int inputLength = inputValues.First().Length - 1;

			foreach (string str in inputValues)
			{
				if (str[inputLength] == '0')
				{
					noOfZeros++;
				}
				else
				{
					noOfOnes++;
				}
			}

			if (noOfOnes > noOfZeros)
			{
				result += "1";
			}
			else
			{
				result += "0";
			}

			return result;
		}
	}
}
