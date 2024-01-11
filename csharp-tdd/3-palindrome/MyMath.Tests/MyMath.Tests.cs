using NUnit.Framework;
using Text;

namespace MyMath.Tests
{
    [TestFixture]
    public class StrTests
    {
        [Test]
        public void IsPalindrome_ValidPalindrome_ReturnsTrue()
        {
            // Arrange
            string palindrome = "Racecar";

            // Act
            bool result = Str.IsPalindrome(palindrome);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_ValidPalindromeWithSpacesAndPunctuation_ReturnsTrue()
        {
            // Arrange
            string palindrome = "A man, a plan, a canal: Panama.";

            // Act
            bool result = Str.IsPalindrome(palindrome);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_ValidPalindromeDifferentCase_ReturnsTrue()
        {
            // Arrange
            string palindrome = "Level";

            // Act
            bool result = Str.IsPalindrome(palindrome);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_NotPalindrome_ReturnsFalse()
        {
            // Arrange
            string notPalindrome = "Hello World";

            // Act
            bool result = Str.IsPalindrome(notPalindrome);

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
        public void IsPalindrome_NullString_ReturnsTrue()
        {
            // Arrange
            string nullString = null;

            // Act
            bool result = Str.IsPalindrome(nullString);

            // Assert
            Assert.IsTrue(result);
        }
    }
}
