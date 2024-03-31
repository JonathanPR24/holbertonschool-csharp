using System;

///<summary>Base class</summary>
abstract class Base
{
    public string Name { get; set; }

    public override string ToString()
    {
        return $"{Name} is a {GetType()}";
    }
}

/// <summary> Interactive interface </summary>
interface IInteractive
{
    void Interact();
}

/// <summary> Breakable Interface </summary>
interface IBreakable
{
    int Durability { get; set; }
    void Break();
}

/// <summary> Collectable Interface </summary>
interface ICollectable
{
    bool IsCollected { get; set; }
    void Collect();
}

/// <summary> Class that inherits from Base class and all interfaces </summary>
class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int Durability { get; set; }
    public bool IsCollected { get; set; }

    public void Interact()
    {
        Console.WriteLine("Interacting...");
    }

    public void Break()
    {
        Console.WriteLine("Breaking...");
    }

    public void Collect()
    {
        Console.WriteLine("Collecting...");
    }
}
