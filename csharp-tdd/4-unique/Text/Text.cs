// 4-unique/Text/Text.cs

using System;
using System.Text;

namespace Text
{
    public static class Str
    {
        public static bool IsPalindrome(string s)
        {
            // Clean the input string and make it case-insensitive
            string cleanedString = CleanAndLowercaseString(s);

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

        public static int UniqueChar(string s)
        {
            // Return the index of the first non-repeating character or -1 if none.

            for (int i = 0; i < s.Length; i++)
            {
                char currentChar = s[i];

                // Check if the current character is not repeated later in the string
                if (s.IndexOf(currentChar, i + 1) == -1 && s.LastIndexOf(currentChar) == i)
                {
                    return i; // Return the index of the first non-repeating character
                }
            }

            return -1; // If no non-repeating character is found
        }

        private static string CleanAndLowercaseString(string input)
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
    }
}
