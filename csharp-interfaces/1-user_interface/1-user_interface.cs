using System;

// Interface for interactive objects
interface IInteractive
{
    void Interact();
}

// Interface for breakable objects
interface IBreakable
{
    int Durability { get; set; }
    void Break();
}

// Interface for collectable objects
interface ICollectable
{
    bool IsCollected { get; set; }
    void Collect();
}

// Base class representing an entity
abstract class Base
{
    protected string name = "";

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public override string ToString()
    {
        return $"{name} is a {GetType()}";
    }
}

// Class representing a test object that inherits from Base and implements the interfaces
class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    // Properties for IBreakable interface
    public int Durability { get; set; }

    // Properties for ICollectable interface
    public bool IsCollected { get; set; }

    // Method implementations for interfaces
    public void Interact()
    {
        // Implementation for interact method
    }

    public void Break()
    {
        // Implementation for break method
    }

    public void Collect()
    {
        // Implementation for collect method
    }
}
