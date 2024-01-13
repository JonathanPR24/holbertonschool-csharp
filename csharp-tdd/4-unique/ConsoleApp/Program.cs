using System;
using Text;

class Program
{
    static void Main()
    {
        string input = "your_test_string_here";
        int result = Str.UniqueChar(input);
        Console.WriteLine($"Index of the first non-repeating character: {result}");
    }
}
