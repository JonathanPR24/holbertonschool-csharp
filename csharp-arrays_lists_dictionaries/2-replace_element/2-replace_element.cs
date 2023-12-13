using System;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array == null)
        {
            Console.WriteLine();
            return;
        }

        Array.Reverse(array);  // Reverse the array in-place

        string result = string.Join(" ", array);
        Console.WriteLine(result);
    }
}
