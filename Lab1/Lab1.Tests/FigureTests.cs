using System.Drawing;
using Lab1;

namespace Lab1.Tests
{
    [TestClass]
    public class FigureTests
    {
        [TestMethod]
        public void GetLength_2PointsInDistanceWithRightOrder()
        {
            //arrange
            Point p1 = new Point(1, 1);
            Point p2 = new Point(1, 4);
            double expected = 3;

            //act
            var actual = Figure.GetLengthSide(p1, p2);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetLength_2PointsInDistanceWithWrongOrder()
        {
            //arrange
            Point p1 = new Point(1, 4);
            Point p2 = new Point(1, 1);
            double expected = 3;

            //act
            var actual = Figure.GetLengthSide(p1, p2);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetLength_2PointsInTheSamePlace()
        {
            //arrange
            Point p1 = new Point(1, 4);
            Point p2 = new Point(1, 4);
            double expected = 0;

            //act
            var actual = Figure.GetLengthSide(p1, p2);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetPerimeterOfRectangleWithDefinedPoints()
        {
            //arrange
            Point p1 = new Point(1, 1);
            Point p2 = new Point(1, 4);
            Point p3 = new Point(5, 1);
            Figure f1 = new Figure("Test", new Point[] { p1, p2, p3 });

            double expected = 12;

            //act
            var actual = f1.GetPerimeter();

            //assert
            Assert.AreEqual(expected, actual);
        }


    }
}