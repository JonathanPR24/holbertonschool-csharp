using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> newDict = new Dictionary<string, int>();

        foreach (KeyValuePair<string, int> entry in myDict)
        {
            // Multiply each value by 2 and add to the new dictionary
            newDict.Add(entry.Key, entry.Value * 2);
        }

        return newDict;
    }
}