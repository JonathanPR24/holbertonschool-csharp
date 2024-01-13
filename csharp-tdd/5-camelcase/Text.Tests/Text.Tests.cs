// Text.Tests/Text.Tests.cs

using NUnit.Framework;
using Text;

[TestFixture]
public class TextTests
{
    [Test]
    public void CamelCase_CountsWordsCorrectly()
    {
        // Arrange
        string input = "ThisIsAExampleString";

        // Act
        int wordCount = Str.CamelCase(input);

        // Assert
        Assert.That(wordCount, Is.EqualTo(5));
    }
}
