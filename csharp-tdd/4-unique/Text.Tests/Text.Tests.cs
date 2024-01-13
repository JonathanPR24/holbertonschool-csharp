using NUnit.Framework;

namespace Tests
{
    public class TextTests
    {
        [SetUp]
        public void Setup()
        {
            // Any setup logic you might need before each test
        }

        [TestCase(0, "abbbbb")]
        [TestCase(1, "babbbb")]
        [TestCase(3, "abcdabc")]
        public void UniqueChar_WithNormalString_ReturnsCorrectIndex(int expected, string input)
        {
            int output = Text.Str.UniqueChar(input);

            Assert.AreEqual(expected, output);
        }

        [TestCase("aabbccdd")]
        [TestCase("")]
        [TestCase(null)]
        public void UniqueChar_WithNoUniqueCharacter_ReturnsNegativeOne(string input)
        {
            int output = Text.Str.UniqueChar(input);

            Assert.AreEqual(-1, output);
        }
    }
}
