using NUnit.Framework;
using Text;

namespace Text.Tests
{
    [TestFixture]
    public class TextTests
    {
        [Test]
        public void IsPalindrome_ValidPalindrome_ReturnsTrue()
        {
            // Arrange
            string palindrome = "A man, a plan, a canal: Panama.";

            // Act
            bool result = Str.IsPalindrome(palindrome);

            // Assert
            Assert.IsTrue(result);
        }

        // Add more test cases as needed
    }
}
