using System;

/// <summary>
/// Represents a class with a method to check if an object is an instance of a subclass.
/// </summary>
public class Obj
{
    /// <summary>
    /// Checks if the object is an instance of a class that inherits from the specified class.
    /// </summary>
    /// <param name="derivedType">The type of the derived class.</param>
    /// <param name="baseType">The type of the base class.</param>
    /// <returns>True if the object is a subclass of the specified base class; otherwise, False.</returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return baseType.IsAssignableFrom(derivedType) && derivedType != baseType;
    }
}
