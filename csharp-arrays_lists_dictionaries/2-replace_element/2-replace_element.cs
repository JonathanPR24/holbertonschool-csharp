﻿using System;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array == null)
        {
            Console.WriteLine();
            return;
        }

        int length = array.Length;

        for (int i = length - 1; i >= 0; i--)
        {
            Console.Write(array[i]);

            if (i > 0)
            {
                Console.Write(" ");
            }
        }

        Console.WriteLine();
    }
}
