using System;

class Int
{
    public static void Divide(int numerator, int denominator)
    {
        const string cannotDivideByZeroMessage = "Cannot divide by zero";
        
        int result = 0;

        try
        {
            result = numerator / denominator;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine(cannotDivideByZeroMessage);
        }
        finally
        {
            Console.WriteLine($"{numerator} / {denominator} = {result}");
        }
    }
}