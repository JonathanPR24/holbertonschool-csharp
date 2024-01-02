﻿using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2)
    {
        List<int> quotients = new List<int>();

        int minLength = Math.Min(list1.Count, list2.Count);

        for (int i = 0; i < minLength; i++)
        {
            try
            {
                quotients.Add(list1[i] / list2[i]);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                quotients.Add(0);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
            }
        }

        return quotients;
    }
}