using System;
using System.Text.RegularExpressions;

namespace Text
{
    public static class Str
    {
        public static bool IsPalindrome(string s)
        {
            // Remove spaces and punctuation, and convert to lowercase
            string cleanedString = Regex.Replace(s, @"[^a-zA-Z]", "").ToLower();

            // Compare the cleaned string with its reverse
            return cleanedString == ReverseString(cleanedString);
        }

        private static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
