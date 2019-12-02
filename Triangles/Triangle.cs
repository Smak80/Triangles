using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
	class Triangle
	{
		public Point A { get; set; }
		public Point B { get; set; }
		public Point C { get; set; }
		private decimal square;
		public decimal Square
		{
			get { return square; }
			private set
			{
				if (value <= 0)
				{
					throw new Exception("Точки на одной прямой");
				}

				square = value;
			}
		}

		public Triangle(Point a, Point b, Point c)
		{
			A = a;
			B = b;
			C = c;
			Square = GetSquare();

		}

		private Point CreateVector(Point a, Point b)
		{
			return new Point(a.X-b.X, a.Y-b.Y);
		}

		private decimal GetVectorLength(Point v)
		{
			var t = v.X * v.X + v.Y * v.Y;
			var d = Math.Sqrt(decimal.ToDouble(t));
			return (decimal)d;
		}

		private decimal GetPerimetr()
		{
			Point ab = CreateVector(A, B);
			Point ac = CreateVector(A, C);
			Point bc = CreateVector(B, C);
			return GetVectorLength(ab) + GetVectorLength(ac) + GetVectorLength(bc);
		}

		private decimal GetSquare()
		{
			Point a = CreateVector(A, B);
			Point b = CreateVector(A, C);
			return 0.5M * Math.Abs(a.X*b.Y-a.Y*b.X);
		}
	}
}
