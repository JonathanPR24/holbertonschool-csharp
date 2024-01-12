// File: Text.Tests/Text.Tests.cs
using NUnit.Framework;
using Text;

namespace Text.Tests
{
    [TestFixture]
    public class StrTests
    {
        [TestCase("Racecar", true)]
        [TestCase("level", true)]
        [TestCase("A man, a plan, a canal: Panama.", true)]
        [TestCase("hello", false)]
        [TestCase("Was it a car or a cat I saw?", true)]
        [TestCase("", true)] // An empty string is considered a palindrome
        [TestCase("No lemon, no melon", true)] // Spaces and punctuation should be ignored
        [TestCase("Palindrome", false)] // Non-palindrome with mixed case
        [TestCase("Able was I ere I saw elba", true)] // Palindrome with spaces
        [TestCase("A Toyota's a Toyota.", true)] // Palindrome with punctuation
        [TestCase("12321", true)] // Numeric palindrome
        [TestCase("12345", false)] // Non-palindrome numeric
        public void IsPalindrome_ValidInputs_ReturnsExpectedResult(string input, bool expectedResult)
        {
            // Arrange, Act
            bool result = Str.IsPalindrome(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
