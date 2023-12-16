using System;
using System.Collections.Generic;
using System.Linq;

class List
{
    public static int Sum(List<int> myList)
    {
        // Use LINQ to filter out duplicate elements and then calculate the sum
        return myList.Distinct().Sum();
    }
}