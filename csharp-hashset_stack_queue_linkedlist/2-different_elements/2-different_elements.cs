using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> differentElements = new List<int>();

        list1.Sort();
        list2.Sort();

        int i = 0, j = 0;

        while (i < list1.Count || j < list2.Count)
        {
            if (j == list2.Count || (i < list1.Count && list1[i] < list2[j]))
                differentElements.Add(list1[i++]);
            else if (i == list1.Count || (j < list2.Count && list1[i] > list2[j]))
                differentElements.Add(list2[j++]);
            else
            {
                i++;
                j++;
            }
        }

        return differentElements;
    }
}