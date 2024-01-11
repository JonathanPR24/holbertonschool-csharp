using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        [Test]
        public void Add_TwoNumbers_ReturnsSum()
        {
            // Arrange
            int a = 5;
            int b = 7;

            // Act
            int result = Operations.Add(a, b);

            // Assert
            Assert.AreEqual(12, result);
        }
    }
}
