using NUnit.Framework;

namespace AreaCalculator.Tests
{
    public class CircleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
		public void Square_Radius_ReturnArea()
		{
			//Arrange
			var circle = new Circle("Круг", 23);
			double expected = 1661.9;

			//Act
			var result = circle.CountArea();

			//Assert
			Assert.AreEqual(expected, result);
		}
	}
}