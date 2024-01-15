using System;

/// <summary>
/// Represents a basic geometric shape.
/// </summary>
class Shape
{
    /// <summary>
    /// Calculates the area of the shape. This method is virtual and throws a NotImplementedException.
    /// </summary>
    /// <returns>Throws NotImplementedException with a message indicating that Area() is not implemented.</returns>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
