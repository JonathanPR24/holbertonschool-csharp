using System;
using System.Text;

namespace Text
{
    /// <summary>
    /// Provides methods for text manipulation.
    /// </summary>
    public static class Str
    {
        /// <summary>
        /// Determines whether a string is a palindrome.
        /// </summary>
        /// <param name="s">The input string.</param>
        /// <returns>True if the string is a palindrome; otherwise, false.</returns>
        public static bool IsPalindrome(string s)
        {
            /// <summary>
            /// Helper function to clean the input string by removing spaces and punctuation and converting to lowercase.
            /// </summary>
            /// <param name="input">The input string to be cleaned.</param>
            /// <returns>The cleaned string.</returns>
            string CleanString(string input)
            {
                StringBuilder cleaned = new StringBuilder();
                foreach (char c in input)
                {
                    if (char.IsLetterOrDigit(c))
                    {
                        cleaned.Append(char.ToLower(c));
                    }
                }
                return cleaned.ToString();
            }

            // Clean the input string
            string cleanedString = CleanString(s);

            // Check if the cleaned string is a palindrome
            int left = 0;
            int right = cleanedString.Length - 1;

            while (left < right)
            {
                if (cleanedString[left] != cleanedString[right])
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }
    }
}
