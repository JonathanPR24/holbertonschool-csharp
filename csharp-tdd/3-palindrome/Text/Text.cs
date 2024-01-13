using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class StrTests
{
    [TestMethod]
    public void IsPalindrome_RegularPalindrome_True()
    {
        string input = "radar";
        bool result = Str.IsPalindrome(input);
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void IsPalindrome_UppercaseLowercaseLetters_True()
    {
        string input = "Racecar";
        bool result = Str.IsPalindrome(input);
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void IsPalindrome_Punctuation_True()
    {
        string input = "A man, a plan, a canal, Panama!";
        bool result = Str.IsPalindrome(input);
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void IsPalindrome_Spaces_True()
    {
        string input = "Was it a car or a cat I saw";
        bool result = Str.IsPalindrome(input);
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void IsPalindrome_EmptyString_True()
    {
        string input = "";
        bool result = Str.IsPalindrome(input);
        Assert.IsTrue(result);
    }
}
