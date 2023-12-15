using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = new int[5, 5];

        array[2, 2] = 1;

        PrintArray(array);
    }

    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j]);

                if (j < array.GetLength(1) - 1)
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }
    }
}
