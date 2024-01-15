using System;

/// <summary>
/// Represents a class with a method to check if an object is an instance of, or inherits from, Array.
/// </summary>
public class Obj
{
    /// <summary>
    /// Checks if the object is an instance of, or inherits from, Array.
    /// </summary>
    /// <param name="obj">The object to check.</param>
    /// <returns>True if the object is an instance of, or inherits from, Array; otherwise, False.</returns>
    public static bool IsInstanceOfArray(object obj)
    {
        return obj is Array;
    }
}
