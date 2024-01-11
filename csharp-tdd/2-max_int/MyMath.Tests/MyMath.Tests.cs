using NUnit.Framework;
using MyMath;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        [Test]
        public void Max_ValidList_ReturnsMaxValue()
        {
            // Arrange
            List<int> nums = new List<int> { 3, 7, 2, 8, 5 };

            // Act
            int result = Operations.Max(nums);

            // Assert
            Assert.AreEqual(8, result);
        }

        [Test]
        public void Max_EmptyList_ReturnsZero()
        {
            // Arrange
            List<int> nums = new List<int>();

            // Act
            int result = Operations.Max(nums);

            // Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Max_NullList_ReturnsZero()
        {
            // Arrange
            List<int> nums = null;

            // Act
            int result = Operations.Max(nums);

            // Assert
            Assert.AreEqual(0, result);
        }
    }
}
