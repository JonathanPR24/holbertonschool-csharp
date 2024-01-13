using System;
using System.Linq;

namespace Text
{
    /// <summary>
    /// Provides methods for string manipulation.
    /// </summary>
    public static class Str
    {
        /// <summary>
        /// Determines whether a string is a palindrome.
        /// </summary>
        /// <param name="s">The input string.</param>
        /// <returns>True if the string is a palindrome, otherwise false.</returns>
        public static bool IsPalindrome(string s)
        {
            // Remove spaces and convert to lowercase
            string cleanedString = new string(s
                .Where(c => Char.IsLetterOrDigit(c))
                .Select(c => Char.ToLower(c))
                .ToArray());

            // Check if the cleaned string is a palindrome
            for (int i = 0, j = cleanedString.Length - 1; i < j; i++, j--)
            {
                if (cleanedString[i] != cleanedString[j])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
