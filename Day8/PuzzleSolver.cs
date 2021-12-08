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
				if (str.Count(c => digit.RightTop.Contains(c)) == 2 && str.Count(c => digit.RightBottom.Contains(c)) == 2)
					return new MappedValue() { Input = string.Concat(str.OrderBy(c => c)), Value = 3 };
				
				if (str.Count(c => digit.RightTop.Contains(c)) == 1 && str.Count(c => digit.RightBottom.Contains(c)) == 1 &&
					str.Count(c => digit.Top.Contains(c)) == 1 && str.Count(c => digit.LeftTop.Contains(c)) == 1)
					return new MappedValue() { Input = string.Concat(str.OrderBy(c => c)), Value = 2 };
			
				return new MappedValue() { Input = string.Concat(str.OrderBy(c => c)), Value = 5 };
			}

			if (arr.Length == 6)
			{
				//if (str.Count(c => digit.Middle.Contains(c)) == 2)
				//	return new MappedValue() { Input = string.Concat(str.OrderBy(c => c)), Value = 0 };

				if (str.Count(c => digit.RightTop.Contains(c)) == 2 && str.Count(c => digit.RightBottom.Contains(c)) == 2 &&
					str.Count(c => digit.Middle.Contains(c)) == 2 && str.Count(c => digit.LeftTop.Contains(c)) == 2)
					return new MappedValue() { Input = string.Concat(str.OrderBy(c => c)), Value = 9 };

				if (str.Count(c => digit.RightTop.Contains(c)) == 1 && str.Count(c => digit.RightBottom.Contains(c)) == 1 &&
					str.Count(c => digit.Top.Contains(c)) == 1 && str.Count(c => digit.LeftTop.Contains(c)) == 2)
					return new MappedValue() { Input = string.Concat(str.OrderBy(c => c)), Value = 6 };
				
				return new MappedValue() { Input = string.Concat(str.OrderBy(c => c)), Value = 0 };
			}

			return new MappedValue() { Input = string.Concat(str.OrderBy(c => c)), Value = 8 };
		}

		private MappedInput MapInput(string input)
		{
			char[] arr = input.ToCharArray();

			if (input.Length == 2) return new MappedInput(arr, 1);

			if (input.Length == 3) return new MappedInput(arr, 7);

			if (input.Length == 4) return new MappedInput(arr, 4);

			if (input.Length == 7) return new MappedInput(arr, 8);

			return null;
		}
	}

	public class MappedInput
	{
		public int Value { get; set; }

		public char[] Chars { get; set; }

		public MappedInput(char[] chars, int value)
		{
			Chars = chars;
			Value = value;
		}
	}
}
