﻿using System;
using System.Linq;
using System.Text;

namespace Text
{
    ///<summary>Defines string manipulation tools.</summary>
    public class Str
    {
        ///<summary>Checks if a string is a palindrome.</summary>
        ///<param name="s">The string to check.</param>
        ///<returns>true if the string is a palindrome, false otherwise.</returns>
        public static bool IsPalindrome(string s)
        {
            s = s.ToLower().Replace(" ", "");
            var sb = new StringBuilder();

            foreach (char c in s)
            {
            if (!char.IsPunctuation(c))
                sb.Append(c);
            }

            s = sb.ToString();
            
            return s.SequenceEqual(s.Reverse());
        }
    }
}