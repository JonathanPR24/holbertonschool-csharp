using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int count = 0;

        try
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(myList[i]);
                count++;
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            // Catch the exception if the index is out of range
            // It means we have reached the end of the list
        }

        return count;
    }
}
