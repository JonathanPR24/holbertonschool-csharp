using System;
using System.Linq;
using System.Text;

namespace Text
{
    /// <summary>
    /// Provides string manipulation tools.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Checks if a string is a palindrome.
        /// </summary>
        /// <param name="s">The string to check.</param>
        /// <returns>True if the string is a palindrome, false otherwise.</returns>
        public static bool IsPalindrome(string s)
        {
            // Convert to lowercase and remove spaces
            string cleanedString = s.ToLower().Replace(" ", "");

            // Remove punctuation
            var sb = new StringBuilder();
            foreach (char c in cleanedString)
            {
                if (!char.IsPunctuation(c))
                    sb.Append(c);
            }
            cleanedString = sb.ToString();

            // Check if it's a palindrome
            return cleanedString.SequenceEqual(cleanedString.Reverse());
        }
    }
}
