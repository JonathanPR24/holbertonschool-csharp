using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // If you need any setup logic for your tests, you can include it here
        }

        [TestCase("abcba", TestName = "Palindrome with lowercase letters")]
        [TestCase("BananasananaB", TestName = "Palindrome with mixed case letters")]
        [TestCase("fubaRabuf", TestName = "Palindrome with mixed case letters")]
        [TestCase("", TestName = "Empty string")]
        [TestCase("Beneb", TestName = "Palindrome with mixed case letters")]
        [TestCase("Ben!neB", TestName = "Palindrome with mixed case letters and punctuation")]
        [TestCase("f o o oof", TestName = "Palindrome with spaces")]
        [TestCase("A man, a plan, a canal: Panama.", TestName = "Palindrome with spaces and punctuation")]
        public void IsPalindrome_NormalString_ReturnsTrue(string input)
        {
            bool result = Text.Str.IsPalindrome(input);

            Assert.IsTrue(result);
        }

        [TestCase("Juan David", TestName = "Non-palindrome with mixed case letters")]
        [TestCase("AbCd", TestName = "Non-palindrome with mixed case letters")]
        public void IsPalindrome_NormalString_ReturnsFalse(string input)
        {
            bool result = Text.Str.IsPalindrome(input);

            Assert.IsFalse(result);
        }
    }
}
