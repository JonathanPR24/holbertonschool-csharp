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

        string reversedArray = string.Join(" ", array.Reverse());
        Console.WriteLine(reversedArray);
    }
}
