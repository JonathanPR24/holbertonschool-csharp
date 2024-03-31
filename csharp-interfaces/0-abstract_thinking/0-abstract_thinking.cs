using System;

/// <summary>
/// Abstract class representing a base entity.
/// </summary>
public abstract class Base
{
    /// <summary>
    /// Gets or sets the name of the entity.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Overrides the ToString method to provide custom string representation.
    /// </summary>
    /// <returns>A string representing the name and type of the entity.</returns>
    public override string ToString()
    {
        return $"{Name} is a {GetType().Name}";
    }
}
