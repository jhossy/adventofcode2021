using System;

namespace Day8
{
	public class FileNote
	{
		public string Input { get; set; }

		public string[] InputArr
		{
			get
			{
				return Input.Split(' ');
			}
		}

		public string Output { get; set; }
	}
}
