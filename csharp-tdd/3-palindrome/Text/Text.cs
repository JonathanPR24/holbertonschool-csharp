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
