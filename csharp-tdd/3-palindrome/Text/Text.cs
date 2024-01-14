using System;
using System.Linq;

namespace Text
{
    /// <summary>
    /// Class containing methods related to strings.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Determines whether a string is a palindrome.
        /// </summary>
        /// <param name="s">The input string.</param>
        /// <returns>True if the string is a palindrome, False otherwise.</returns>
        public static bool IsPalindrome(string s)
        {
            // Implementation of the palindrome check
            // (Case-insensitive, ignoring spaces and punctuation)
            
            // Remove spaces and punctuation from the string
            string cleanString = new string(s.Where(c => Char.IsLetterOrDigit(c)).ToArray());

            // Convert to lowercase for case-insensitive comparison
            cleanString = cleanString.ToLower();

            // Compare the original and reversed strings
            return cleanString == new string(cleanString.Reverse().ToArray());
        }
    }
}
