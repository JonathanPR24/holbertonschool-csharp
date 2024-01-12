// File: Text/Str.cs
namespace Text
{
    /// <summary>
    /// Provides methods for working with strings.
    /// </summary>
    public static class Str
    {
        /// <summary>
        /// Determines if a string is a palindrome.
        /// </summary>
        /// <param name="s">The input string.</param>
        /// <returns>True if the string is a palindrome, otherwise false.</returns>
        public static bool IsPalindrome(string s)
        {
            // Remove spaces and punctuation, and convert to lowercase
            string cleanedString = CleanString(s);

            // Check if the cleaned string is a palindrome
            return IsPalindromeCheck(cleanedString);
        }

        /// <summary>
        /// Removes spaces and punctuation from a string and converts it to lowercase.
        /// </summary>
        /// <param name="s">The input string.</param>
        /// <returns>The cleaned string.</returns>
        private static string CleanString(string s)
        {
            // Remove spaces and punctuation, and convert to lowercase
            string cleanedString = "";
            foreach (char c in s)
            {
                if (char.IsLetterOrDigit(c))
                {
                    cleanedString += char.ToLower(c);
                }
            }
            return cleanedString;
        }

        /// <summary>
        /// Checks if the given string is a palindrome.
        /// </summary>
        /// <param name="s">The input string.</param>
        /// <returns>True if the string is a palindrome, otherwise false.</returns>
        private static bool IsPalindromeCheck(string s)
        {
            // Check if the string is a palindrome
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                if (s[left] != s[right])
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
