using System;


class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10, 10);

        // Checks if number is positive, negative, or zero
        if (number > 0)
        {
            Console.WriteLine($"{number} is positve");
        }
        else if (number < 0)
        {
            Console.WriteLine($"{number} is negative");
        }
        else
        {
            Console.WriteLine($"{number} is zero");
        }
    }
}
``` 