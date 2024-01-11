using System;
using System.Text;

namespace Text
{
    /// <summary>
    /// Class for string functions.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Checks if a string is a palindrome.
        /// </summary>
        /// <param name="s">The string to check.</param>
        /// <returns>True if palindrome, otherwise false.</returns>
        public static bool IsPalindrome(string s)
        {
            if (s == null)
            {
                throw new ArgumentNullException(nameof(s));
            }

            StringBuilder normalized = new StringBuilder();

            foreach (char c in s)
            {
                if (char.IsLetter(c))
                {
                    normalized.Append(char.ToLower(c));
                }
            }

            int i = 0;
            int j = normalized.Length - 1;

            while (i < j)
            {
                if (normalized[i] != normalized[j])
                {
                    return false;
                }

                i++;
                j--;
            }

            return true;
        }
    }
}
