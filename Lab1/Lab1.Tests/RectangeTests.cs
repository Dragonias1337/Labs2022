using System.Drawing;
using Lab1;

namespace Lab1.Tests
{
    [TestClass]
    internal class RectangeTests
    {
        [TestMethod]
        public void AreaOfRectangle()
        {
            //arrange
            Rectangle r1 = new Rectangle(10, 5);
            double expected = 50;

            //act         
            double actual = r1.Area;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PerimeterOfRectangle()
        {
            //arrange
            Rectangle rectangle = new Rectangle(10, 5);
            double expected = 30;

            //act
            double actual = rectangle.Perimeter;

            //assert
            Assert.AreEqual(expected, actual);
            
        }
    }
}
