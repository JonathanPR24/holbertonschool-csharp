using NUnit.Framework;

namespace Tests
{
    public class StrTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("abcba", TestName = "IsPalindrome_SingleWordPalindrome_ReturnsTrue")]
        [TestCase("BananasananaB", TestName = "IsPalindrome_MixedCasePalindrome_ReturnsTrue")]
        [TestCase("fubaRabuf", TestName = "IsPalindrome_MixedCaseNonPalindrome_ReturnsFalse")]
        [TestCase("", TestName = "IsPalindrome_EmptyString_ReturnsTrue")]
        [TestCase("Beneb", TestName = "IsPalindrome_SingleWordNonPalindrome_ReturnsFalse")]
        [TestCase("Ben!neB", TestName = "IsPalindrome_NonAlphanumericCharacters_ReturnsTrue")]
        [TestCase("f o o oof", TestName = "IsPalindrome_WhitespacePalindrome_ReturnsTrue")]
        [TestCase("A man, a plan, a canal: Panama.", TestName = "IsPalindrome_ComplexPalindrome_ReturnsTrue")]
        public void IsPalindrome_ValidInput_ReturnsTrue(string input)
        {
            bool result = Text.Str.IsPalindrome(input);

            Assert.IsTrue(result, $"Expected true for input: '{input}'");
        }

        [TestCase("Juan David", TestName = "IsPalindrome_NonPalindromeWithSpace_ReturnsFalse")]
        [TestCase("AbCd", TestName = "IsPalindrome_MixedCaseNonPalindrome_ReturnsFalse")]
        public void IsPalindrome_NonPalindrome_ReturnsFalse(string input)
        {
            bool result = Text.Str.IsPalindrome(input);

            Assert.IsFalse(result, $"Expected false for input: '{input}'");
        }
    }
}
