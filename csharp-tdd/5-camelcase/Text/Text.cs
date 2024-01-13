// Text/Text.cs

namespace Text
{
    /// <summary>
    /// Contains methods for working with strings.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Counts the number of words in a string.
        /// Each word begins with a capital letter, except the first word.
        /// </summary>
        /// <param name="s">The input string.</param>
        /// <returns>The number of words in the string.</returns>
        public static int CamelCase(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            int wordCount = 1; // Assume at least one word (the first one)

            foreach (char c in s)
            {
                // Check if the character is an uppercase letter
                if (char.IsUpper(c))
                {
                    // Increment the word count for each uppercase letter (except the first one)
                    wordCount++;
                }
            }

            return wordCount;
        }
    }
}
