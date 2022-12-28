using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
	public class Triangle : Shape
	{
		public double EdgeA { get; set; }
		public double EdgeB { get; set; }
		public double EdgeC { get; set; }

		public Triangle(string typeName, double a, double b, double c) : base(typeName)
		{
			if (isReal(a, b, c))
			{
				EdgeA = a;
				EdgeB = b;
				EdgeC = c;
			} else {
				throw new Exception("You couldn't create triangle with this edges!");
			}
		}

		public override double CountArea()
		{
			var halfPerimeter = (EdgeA + EdgeB + EdgeC) / 2;
			var area = Math.Sqrt(halfPerimeter * (halfPerimeter - EdgeA) * (halfPerimeter - EdgeB) * (halfPerimeter - EdgeC));
			return area;
		}

		public bool isStraightTriangle()
		{
			bool isStraight = (EdgeA == Math.Sqrt(Math.Pow(EdgeB, 2) + Math.Pow(EdgeC, 2))
			                   || EdgeB == Math.Sqrt(Math.Pow(EdgeA, 2) + Math.Pow(EdgeC, 2))
			                   || EdgeC == Math.Sqrt(Math.Pow(EdgeA, 2) + Math.Pow(EdgeB, 2)));

			return isStraight;
		}

		private bool isReal(double a, double b, double c)
		{
			if (a < 0 || b < 0 || c < 0 || (a < (b + c) || b < (a + c) || c < (a + b))) return false;
			return true;
		}
	}
}
