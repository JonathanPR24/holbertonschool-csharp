using System;

class Except
{
    public static void Throw()
    {
        throw new Exception("Custom Exception");
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Except.Throw();
        }
        catch (Exception)
        {
            Console.WriteLine("Exception raised");
        }
    }
}