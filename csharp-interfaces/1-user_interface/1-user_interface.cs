using System;

// Base class
abstract class Base
{
    public string name = "";

    public override string ToString()
    {
        return $"{name} is a {GetType()}";
    }
}

// Interactive interface
interface IInteractive
{
    void Interact();
}

// Breakable Interface
interface IBreakable
{
    int durability { get; set; }
    void Break();
}

// Collectable Interface
interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

// Class that inherits from Base class and all interfaces
class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability { get; set; }
    public bool isCollected { get; set; }

    // Takes place when the object interacts with something
    public void Interact()
    {
        Console.WriteLine("Interacting...");
    }

    // Takes place when the object breaks
    public void Break()
    {
        Console.WriteLine("Breaking...");
    }

    // Takes place when the object collects something
    public void Collect()
    {
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
