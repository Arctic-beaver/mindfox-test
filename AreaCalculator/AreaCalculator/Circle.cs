using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
	public class Circle : Shape
	{
		public double Radius { get; set; }

		public Circle(string typeName, double radius) : base(typeName)
		{
			Radius = radius;
		}

		public override double CountArea()
		{
			double result = Math.PI * Math.Pow(Radius, 2);
			return Math.Round(result, 1);
		}
	}
}
