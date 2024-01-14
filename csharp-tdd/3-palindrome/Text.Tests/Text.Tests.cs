using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void SimplePalindrome()
        {
            string str = "radar";

            Assert.IsTrue(Text.Str.IsPalindrome(str));
        }

        [Test]
        public void NonPalindrome()
        {
            string str = "hello";

            Assert.IsFalse(Text.Str.IsPalindrome(str));
        }

        [Test]
        public void SingleCharacter()
        {
            string str = "a";

            Assert.IsTrue(Text.Str.IsPalindrome(str));
        }

        [Test]
        public void NullString()
        {
            string str = null;

            Assert.IsFalse(Text.Str.IsPalindrome(str));
        }

        [Test]
        public void MixedCasePalindrome()
        {
            string str = "RacECar";

            Assert.IsTrue(Text.Str.IsPalindrome(str));
        }

        [Test]
        public void SpecialCharactersPalindrome()
        {
            string str = "!@#$%^&*()(*&^%$#@!";

            Assert.IsTrue(Text.Str.IsPalindrome(str));
        }

        [Test]
        public void LongPalindrome()
        {
            string str = "A man, a plan, a canal, Panama. A man, a plan, a canal, Panama.";

            Assert.IsTrue(Text.Str.IsPalindrome(str));
        }
    }
}
