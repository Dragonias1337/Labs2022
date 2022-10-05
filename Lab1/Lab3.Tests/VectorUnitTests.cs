namespace Lab3.Tests
{
    [TestClass]
    public class VectorUnitTests
    {
        [TestMethod]
        public void TestAddOperator()
        {
            Vector v1 = new Vector() { X = 2, Y = 3, Z = 4 };
            Vector v2 = new Vector() { X = 3, Y = 4, Z = 5 };

            Vector actual = v1 + v2;
            Vector expected = new Vector() { X = 5, Y = 7, Z = 9 };

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultipleOperator()
        {
            Vector v1 = new Vector() { X = 2, Y = 3, Z = 4 };
            Vector v2 = new Vector() { X = 3, Y = 4, Z = 5 };

            int actual = v1 * v2;
            int expected = 6 + 12 + 20;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultipleByNumberOperator()
        {
            Vector v1 = new Vector() { X = 2, Y = 3, Z = 4 };

            Vector actual = v1 * 3;
            Vector expected = new Vector() { X = 6, Y = 9, Z = 12 };

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestComparison()
        {
            Vector v1 = new Vector() { X = 2, Y = 3, Z = 4 };
            Vector v2 = new Vector() { X = 3, Y = 4, Z = 5 };

            Assert.IsFalse(v1 == v2);
            Assert.IsTrue(v1 == v1);
            Assert.IsTrue(v1 != v2);
            Assert.IsTrue(v2 > v1);
            Assert.IsTrue(v2 >= v1);
            Assert.IsFalse(v2 < v1);
            Assert.IsFalse(v2 <= v1);
        }
    }
}