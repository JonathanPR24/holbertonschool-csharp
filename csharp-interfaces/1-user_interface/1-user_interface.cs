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

/// <summary>
/// Interactive interface
/// </summary>
interface IInteractive
{
    void Interact();
}

/// <summary>
/// Breakable Interface
/// </summary>
interface IBreakable
{
    int durability { get; set; }
    void Break();
}

/// <summary>
/// Collectable Interface
/// </summary>
interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

/// <summary>
/// Class that inherits from Base class and all interfaces
/// </summary>
class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability { get; set; }
    public bool isCollected { get; set; }

    public void Interact()
    {
        // Implementation for Interact method
        Console.WriteLine("Interacting...");
    }

    public void Break()
    {
        // Implementation for Break method
        Console.WriteLine("Breaking...");
    }

    public void Collect()
    {
        // Implementation for Collect method
        Console.WriteLine("Collecting...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        TestObject item = new TestObject();
        Type type = item.GetType();

        Console.WriteLine("Type: " + type);

        Console.WriteLine("Properties:");
        foreach (var property in type.GetProperties())
            Console.WriteLine(property.Name);

        Console.WriteLine("Methods:");
        foreach (var method in type.GetMethods())
            Console.WriteLine(method.Name);
    }
}
