using System.Linq;

namespace Day8
{
	public class Digit
	{
		public string Top;
		public string LeftTop;
		public string RightTop;
		public string Middle;
		public string LeftBottom;
		public string RightBottom;
		public string Bottom;

		//internal char[] MightBe(char[] value)
		//{
		//	if(value.Length == 3) //7
		//	{
		//		return value.Where(x => !RightTop.Contains(x)).ToArray();
		//		//Top = value.SingleOrDefault(x => !RightTop.Contains(x))
		//	}

		//	if(value.Length == 4) //4
		//	{
		//		return value.Where(x => !RightTop.Contains(x) && !RightBottom.Contains(x)).ToArray();
		//		//LeftTop = Middle = value.Where(x => !RightTop.Contains(x) && !RightBottom.Contains(x)).ToArray();
		//	}

		//	if (value.Length == 5) //2, 3, 5
		//	{
		//		return value.Where(x => RightTop.Contains(x) && RightBottom.Contains(x)).ToArray(); //3

		//		return value.Where(x => RightTop.Contains(x) && !RightBottom.Contains(x)).ToArray(); //2

		//		return value.Where(x => !RightTop.Contains(x) && LeftBottom.Contains(x)).ToArray();	//5
		//	}

		//	//if(value.Length == 6) //0, 6, 9
		//	//{
		//	//	return value.Where(x => !Middle.Contains(x))
		//	//}


		//	return new char[0];
		//}
	}
}
