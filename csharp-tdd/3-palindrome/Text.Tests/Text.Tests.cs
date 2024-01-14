using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void SimpleString()
        {
            string str = "abcba";

            Assert.IsTrue(Text.Str.IsPalindrome(str));
        }

        [Test]
        public void IgnoreCase()
        {
            string str = "AbCba";

            Assert.IsTrue(Text.Str.IsPalindrome(str));
        }

        [Test]
        public void IgnoreCase2()
        {
            string str = "Racecar";

            Assert.IsTrue(Text.Str.IsPalindrome(str));
        }

        [Test]
        public void SpacesIgnored()
        {
            string str = "Race car";

            Assert.IsTrue(Text.Str.IsPalindrome(str));
        }

        [Test]
        public void PunctuationIgnored()
        {
            string str = "Aman,aplan,acanal:Panama.";

            Assert.IsTrue(Text.Str.IsPalindrome(str));
        }

        [Test]
        public void PunctuationAndSpacesIgnored()
        {
            string str = "A man, a plan, a canal: Panama.";

            Assert.IsTrue(Text.Str.IsPalindrome(str));
        }

        [Test]
        public void EmptyString()
        {
            string str = "";

            Assert.IsTrue(Text.Str.IsPalindrome(str));
        }
    }
}