using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, string> DeleteKeyValue(Dictionary<string, string> myDict, string key)
    {
        if (myDict.ContainsKey(key))
        {
            // If key exists, remove it
            myDict.Remove(key);
        }

        return myDict;
    }
}