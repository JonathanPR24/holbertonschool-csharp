using System;
using System.Reflection;

/// <summary>
/// Represents a class with a method to print the names of properties and methods of an object.
/// </summary>
public class Obj
{
    /// <summary>
    /// Prints the names of available properties and methods of an object.
    /// </summary>
    /// <param name="myObj">The object to inspect.</param>
    public static void Print(object myObj)
    {
        Type objType = myObj.GetType();
        
        // Print properties
        Console.WriteLine($"{objType.Name} Properties:");
        foreach (var property in objType.GetProperties())
        {
            Console.WriteLine(property.Name);
        }

        // Print methods
        Console.WriteLine($"{objType.Name} Methods:");
        foreach (var method in objType.GetMethods())
        {
            Console.WriteLine(method.Name);
        }
    }
}
