using NUnit.Framework;

namespace Text.Tests
{
    /// <summary>
    /// Tests for the Str class.
    /// </summary>
    public class StrTests
    {
        /// <summary>
        /// Tests the IsPalindrome method with a palindrome string.
        /// </summary>
        [Test]
        public void IsPalindrome_PalindromeString_ReturnsTrue()
        {
            // Arrange
            string palindrome = "racecar";

            // Act
            bool result = Str.IsPalindrome(palindrome);

            // Assert
            Assert.IsTrue(result);
        }

        // Add more test methods for different cases (non-palindromes, edge cases, etc.)
        // ...
    }
}
