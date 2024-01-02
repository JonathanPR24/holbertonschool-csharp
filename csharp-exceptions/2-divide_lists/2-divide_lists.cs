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
                    int dividend = list1.Count > i ? list1[i] : 0;
                    int divisor = list2.Count > i ? list2[i] : 1; // Default divisor to 1 to avoid division by zero

                    if (divisor == 0)
                    {
                        throw new DivideByZeroException();
                    }

                    result.Add(dividend / divisor);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero");
                    result.Add(0);
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Out of range");
                    break; // Stop processing if either list is too short
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }

        return result;
    }
}