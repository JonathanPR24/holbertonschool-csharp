using NUnit.Framework;
using Text;

namespace Text.Tests
{
    [TestFixture]
    public class StrTests
    {
        [Test]
        public void IsPalindrome_WhenPalindrome_ReturnsTrue()
        {
            // Arrange
            string palindrome = "Racecar";

            // Act
            bool result = Str.IsPalindrome(palindrome);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_WhenNotPalindrome_ReturnsFalse()
        {
            // Arrange
            string notPalindrome = "Hello";

            // Act
            bool result = Str.IsPalindrome(notPalindrome);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void IsPalindrome_WithSpacesAndPunctuation_ReturnsTrue()
        {
            // Arrange
            string stringWithSpacesAndPunctuation = "A man, a plan, a canal: Panama.";

            // Act
            bool result = Str.IsPalindrome(stringWithSpacesAndPunctuation);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_WithEmptyString_ReturnsTrue()
        {
            // Arrange
            string emptyString = "";

            // Act
            bool result = Str.IsPalindrome(emptyString);

            // Assert
            Assert.IsTrue(result);
        }
    }
}
