using System;

namespace Text
{
    /// <summary>
    /// Class containing methods for string manipulation.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Finds the index of the first non-repeating character in a string.
        /// </summary>
        /// <param name="s">The input string.</param>
        /// <returns>The index of the first unique character, or -1 if none found.</returns>
        public static int UniqueChar(string s)
        {
            if (s == null)
                return -1;

            int[] counter = new int[26];

            foreach (char c in s.ToCharArray())
            {
                counter[c - 'a'] += 1;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (counter[s[i] - 'a'] == 1)
                    return i;
            }

            return -1;
        }
    }
}
