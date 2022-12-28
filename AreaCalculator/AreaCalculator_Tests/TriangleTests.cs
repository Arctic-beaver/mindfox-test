using NUnit.Framework;
using System;

namespace AreaCalculator.Tests
{
    public class TriangleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void newTriangle_NotReal_ThrowException()
        {
            //Arrange
            bool isErrorOccured = false;
            Triangle triangle;

            //Act
            try {
                triangle = new Triangle("Triangle", 2, 13, 13);
            } catch (Exception ex) {
                isErrorOccured = true;
            }

            //Assert
            Assert.IsTrue(isErrorOccured);
        }

        [Test]
        public void isStraightTriangle_NotStraight_ReturnFalse()
        {
            //Arrange
            var triangle = new Triangle("Triangle", 2, 3, 4);

            //Act
            var result = triangle.isStraightTriangle();

            //Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void CountArea_Edges_ReturnArea()
        {
            //Arrange
            var triangle = new Triangle("Triangle", 3, 4, 5);
            double expected = 6;

            //Act
            var result = triangle.CountArea();

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}