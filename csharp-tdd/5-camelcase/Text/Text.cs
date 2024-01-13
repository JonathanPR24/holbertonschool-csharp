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

            int wordCount = 0;

            // Check the first character
            if (char.IsUpper(s[0]))
            {
                wordCount++;
            }

            // Iterate through the rest of the characters
            for (int i = 1; i < s.Length; i++)
            {
                // Check if the character is an uppercase letter
                if (char.IsUpper(s[i]))
                {
                    // Increment the word count for each uppercase letter
                    wordCount++;
                }
            }

            return wordCount;
        }
    }
}
