﻿using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i <= 8; i++)
        {
            for (int j = i + 1; j <= 9; j++)
            {
                Console.Write($"{i}{j}{(i == 8 && j == 9 ? "\n" : ", ")}");
            }
        }
    }
}
