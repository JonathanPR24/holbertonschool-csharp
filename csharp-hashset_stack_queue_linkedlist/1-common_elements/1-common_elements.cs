using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        list1.Sort();
        list2.Sort();

        List<int> commonElements = new List<int>();
        for (int i = 0, j = 0; i < list1.Count && j < list2.Count;)
        {
            if (list1[i] == list2[j])
            {
                commonElements.Add(list1[i++]);
                j++;
            }
            else if (list1[i] < list2[j])
            {
                i++;
            }
            else
            {
                j++;
            }
        }

        return commonElements;
    }
}