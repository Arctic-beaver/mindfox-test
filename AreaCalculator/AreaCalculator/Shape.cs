using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
	public abstract class Shape
	{
		public string ShapeType { get; set; }

		public Shape(string shapeType)
		{
			ShapeType = shapeType;
		}

		public abstract double CountArea();

		public override string ToString()
		{
			return $"Current shape is: {ShapeType}";
		}
	}
}
