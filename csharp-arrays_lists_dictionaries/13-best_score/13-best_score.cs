using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList.Count == 0)
        {
            return "None";
        }

        string bestStudent = "";
        int maxScore = int.MinValue;

        foreach (KeyValuePair<string, int> entry in myList)
        {
            if (entry.Value > maxScore)
            {
                maxScore = entry.Value;
                bestStudent = entry.Key;
            }
        }

        return bestStudent;
    }
}