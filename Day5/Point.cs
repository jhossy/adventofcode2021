using System;
using System.Collections.Generic;

namespace Day5
{
	public class Point
	{
		public int X { get; set; }

		public int Y { get; set; }

		public Point()
		{

		}

		public Point(int x, int y)
		{
			X = x;
			Y = y;
		}

		public override string ToString()
		{
			return $"({X}, {Y})";
		}
	}

    class PointComparer : IEqualityComparer<Point>
    {
        // Products are equal if their names and product numbers are equal.
        public bool Equals(Point x, Point y)
        {

            //Check whether the compared objects reference the same data.
            if (Object.ReferenceEquals(x, y)) return true;

            //Check whether any of the compared objects is null.
            if (Object.ReferenceEquals(x, null) || Object.ReferenceEquals(y, null))
                return false;

            //Check whether the products' properties are equal.
            return x.X == y.X && x.Y == y.Y;
        }

        // If Equals() returns true for a pair of objects
        // then GetHashCode() must return the same value for these objects.

        public int GetHashCode(Point point)
        {
            //Check whether the object is null
            if (Object.ReferenceEquals(point, null)) return 0;

            //Get hash code for the X field if it is not null.
            int hashX = point.X.GetHashCode();

            //Get hash code for the Y field.
            int hashY = point.Y.GetHashCode();

            //Calculate the hash code for the point.
            return hashX ^ hashY;
        }
    }
}
