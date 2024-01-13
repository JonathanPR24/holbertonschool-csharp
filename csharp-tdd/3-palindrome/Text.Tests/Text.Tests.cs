using NUnit.Framework;

[TestFixture]
public class StrTests
{
    [TestCase("Racecar", true)]
    [TestCase("level", true)]
    [TestCase("A man, a plan, a canal: Panama.", true)]
    [TestCase("Hello", false)]
    [TestCase("", true)] // An empty string is considered a palindrome
    [TestCase("Was it a car or a cat I saw?", true)] // Ignoring spaces and punctuation
    [TestCase("No 'x' in Nixon", true)] // Ignoring spaces and punctuation
    [TestCase("Not a palindrome", false)]
    public void IsPalindromeTest(string input, bool expectedResult)
    {
        bool result = Text.Str.IsPalindrome(input);
        Assert.AreEqual(expectedResult, result);
    }
}
