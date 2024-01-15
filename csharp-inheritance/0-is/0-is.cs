using System;

/// <summary>
/// Represents a class with a method to check if an object is of type int.
/// </summary>
class Obj
{
    /// <summary>
    /// Checks if the object is of type int.
    /// </summary>
    /// <param name="obj">The object to check.</param>
    /// <returns>True if the object is of type int, otherwise False.</returns>
    public static bool IsOfTypeInt(object obj)
    {
        return obj is int;
    }
}
