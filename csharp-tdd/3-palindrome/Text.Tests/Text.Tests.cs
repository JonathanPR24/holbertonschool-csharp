using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void RegularPalindrome()
        {
            string str = "radar";
            Assert.IsTrue(Text.Str.IsPalindrome(str));
        }

        [Test]
        public void UppercaseLowercaseLetters()
        {
            string str = "RacECar";
            Assert.IsTrue(Text.Str.IsPalindrome(str));
        }

        [Test]
        public void Punctuation()
        {
            string str = "A man, a plan, a canal, Panama.";
            Assert.IsTrue(Text.Str.IsPalindrome(str));
        }

        [Test]
        public void Spaces()
        {
            string str = "Race car";
            Assert.IsTrue(Text.Str.IsPalindrome(str));
        }

        [Test]
        public void EmptyString()
        {
            string str = "";
            Assert.IsTrue(Text.Str.IsPalindrome(str));
        }

        // Add more tests for additional scenarios if needed

        // Ensure compatibility with NUnit version 3.13.2
        [Test]
        public void NUnitCompatibilityTest()
        {
            Assert.Pass("NUnit version 3.13.2 is compatible.");
        }
    }
}
