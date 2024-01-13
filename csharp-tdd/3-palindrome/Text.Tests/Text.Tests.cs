using NUnit.Framework;
using Text;

namespace Text.Tests
{
    [TestFixture]
    public class StrTests
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

        [Test]
        public void IsPalindrome_ValidNonPalindrome_ReturnsFalse()
        {
            // Arrange
            string nonPalindrome = "Hello, World!";

            // Act
            bool result = Str.IsPalindrome(nonPalindrome);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void IsPalindrome_EmptyString_ReturnsTrue()
        {
            // Arrange
            string emptyString = "";

            // Act
            bool result = Str.IsPalindrome(emptyString);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_SingleCharacterString_ReturnsTrue()
        {
            // Arrange
            string singleCharString = "a";

            // Act
            bool result = Str.IsPalindrome(singleCharString);

            // Assert
            Assert.IsTrue(result);
        }
    }
}
