using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> result = new List<int>();

        try
        {
            for (int i = 0; i < listLength; i++)
            {
                try
                {
                    int divisionResult = list2[i] == 0 ? 0 : list1[i] / list2[i];
                    result.Add(divisionResult);
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Out of range");
                }
            }
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }

        return result;
    }
}