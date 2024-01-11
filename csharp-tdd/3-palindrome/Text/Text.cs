using System;
using System.Linq;

namespace Text
{
    /// <summary>
    /// Provides string manipulation methods.
    /// </summary>
    public static class Str
    {
        /// <summary>
        /// Determines if a given string is a palindrome.
        /// </summary>
        /// <param name="s">The input string.</param>
        /// <returns>True if the string is a palindrome, otherwise false.</returns>
        public static bool IsPalindrome(string s)
        {
            // Convert the string to lowercase and remove spaces and punctuation
            string cleanedString = new string(s.ToLower().Where(c => Char.IsLetterOrDigit(c)).ToArray());

            // Check if the cleaned string is equal to its reverse
            return cleanedString == new string(cleanedString.Reverse().ToArray());
        }
    }
}
