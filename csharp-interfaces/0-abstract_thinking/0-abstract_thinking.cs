using System;

/// <summary>
/// Abstract base class representing an entity.
/// </summary>
abstract class Base
{
    /// <summary>
    /// Gets or sets the name of the entity.
    /// </summary>
    public string name = "";

    /// <summary>
    /// Overrides the ToString method to provide custom string representation.
    /// </summary>
    /// <returns>A string representing the name and type of the entity.</returns>
    public override string ToString()
    {
        return $"{name} is a {GetType()}";
    }
}
