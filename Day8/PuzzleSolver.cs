using System.Linq;
using static Day8.Program;

namespace Day8
{
	public class MappedValue
	{
		public string Input { get; set; }

		public int Value { get; set; }
	}

	public class PuzzleSolver
	{
		public MappedValue Solve(Digit digit, string str)
		{
			char[] arr = str.ToCharArray();
			
			if (arr.Length == 2) //1
			{
				digit.RightTop = str;
				digit.RightBottom = str;
				return new MappedValue() { Input = string.Concat(str.OrderBy(c => c)), Value = 1 };
			}

			if (arr.Length == 3) //7
			{
				string res = "";
				foreach(char c in arr)
				{
					if (!digit.RightTop.Contains(c))
					{
						res += c;
					}
				}

				digit.Top = res;
				return new MappedValue() { Input = string.Concat(str.OrderBy(c => c)), Value = 7 };
			}

			if (arr.Length == 4) //4
			{
				string res = "";
				foreach (char c in arr)
				{
					if (!digit.RightTop.Contains(c) && !digit.RightBottom.Contains(c))
					{
						res += c;
					}
				}
				digit.LeftTop = res;
				digit.Middle = res;
				return new MappedValue() { Input = string.Concat(str.OrderBy(c => c)), Value = 4 };
			}

			if (arr.Length == 5)
			{
				if(digit.RightTop.Count(c => str.Contains(c)) == 2 && digit.RightBottom.Count(c => str.Contains(c)) == 2)
					return new MappedValue() { Input = string.Concat(str.OrderBy(c => c)), Value = 3 };

				if (digit.RightTop.Count(c => str.Contains(c)) == 1 && digit.Middle.Count(c => str.Contains(c)) == 2)
					return new MappedValue() { Input = string.Concat(str.OrderBy(c => c)), Value = 5 };

				return new MappedValue() { Input = string.Concat(str.OrderBy(c => c)), Value = 2 };
			}

			if (arr.Length == 6)
			{
				if(digit.Middle.Count(c => str.Contains(c)) == 1 || digit.LeftTop.Count(c => str.Contains(c)) == 1)
					return new MappedValue() { Input = string.Concat(str.OrderBy(c => c)), Value = 0 };

				int cnt = digit.RightTop.Count(c => str.Contains(c));
				if (digit.RightTop.Count(c => str.Contains(c)) == 2)
					return new MappedValue() { Input = string.Concat(str.OrderBy(c => c)), Value = 9 };

				return new MappedValue() { Input = string.Concat(str.OrderBy(c => c)), Value = 6 };
			}

			return new MappedValue() { Input = string.Concat(str.OrderBy(c => c)), Value = 8 };
		}
	}
}
