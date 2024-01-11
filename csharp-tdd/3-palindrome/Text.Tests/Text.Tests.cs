using NUnit.Framework;

namespace Text.Tests
{
    public class StrTests
    {
        [TestCase("Racecar", true)] // Regular palindrome
        [TestCase("level", true)] // Uppercase + lowercase letters
        [TestCase("A man, a plan, a canal: Panama.", true)] // Punctuation
        [TestCase("Never odd or even", true)] // Spaces
        [TestCase("", true)] // Empty string
        [TestCase("hello", false)] // Non-palindrome
        [TestCase("Palindrome", false)] // Non-palindrome
        [TestCase("Not a palindrome", false)] // Non-palindrome
        public void IsPalindrome_ValidInput_ReturnsExpected(string input, bool expected)
        {
            // Act
            bool result = Str.IsPalindrome(input);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
