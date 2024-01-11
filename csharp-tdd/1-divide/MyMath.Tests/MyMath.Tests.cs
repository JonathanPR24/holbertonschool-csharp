using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    [TestFixture]
    public class MyMathTests
    {
        [Test]
        public void RegularDivision()
        {
            int[,] matrix = { { 4, 8 }, { 12, 16 } };
            int num = 2;

            int[,] result = Matrix.Divide(matrix, num);

            Assert.AreEqual(2, result[0, 0]);
            Assert.AreEqual(4, result[0, 1]);
            Assert.AreEqual(6, result[1, 0]);
            Assert.AreEqual(8, result[1, 1]);
        }

        [Test]
        public void DivideByZero()
        {
            int[,] matrix = { { 4, 8 }, { 12, 16 } };
            int num = 0;

            int[,] result = Matrix.Divide(matrix, num);

            Assert.IsNull(result);
            // You may want to add additional assertions based on the expected behavior.
        }

        [Test]
        public void MatrixIsNull()
        {
            int[,] matrix = null;
            int num = 2;

            int[,] result = Matrix.Divide(matrix, num);

            Assert.IsNull(result);
            // You may want to add additional assertions based on the expected behavior.
        }
    }
}
