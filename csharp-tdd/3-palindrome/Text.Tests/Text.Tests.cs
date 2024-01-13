using NUnit.Framework;

[TestFixture]
public class StrTests
{
    [TestCase("Racecar", true, TestName = "Regular palindrome")]
    [TestCase("level", true, TestName = "Uppercase + lowercase letters")]
    [TestCase("A man, a plan, a canal: Panama.", true, TestName = "Punctuation")]
    [TestCase("Was it a car or a cat I saw?", true, TestName = "Spaces")]
    [TestCase("", true, TestName = "Empty string")]
    [TestCase("Hello", false, TestName = "Not a palindrome")]
    [TestCase("No 'x' in Nixon", true, TestName = "Punctuation + Spaces")]
    [TestCase("Able ,was I saw eLba", true, TestName = "Uppercase + lowercase letters + Punctuation + Spaces")]
    public void IsPalindromeTest(string input, bool expectedResult)
    {
        bool result = Text.Str.IsPalindrome(input);
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
