using System;

///<summary>Base class</summary>
abstract class Base
{
    public string name = "";

    public override string ToString()
    {
        return $"{name} is a {GetType()}";
    }
}

///<summary>Interactive interface</summary>
interface IInteractive
{
    void Interact();
}

///<summary>Breakable interface</summary>
interface IBreakable
{
    int durability { get; set; }
    void Break();
}

///<summary>Collectable interface</summary>
interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

///<summary>Class that inherits from Base class and all interfaces</summary>
class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability { get; set; }
    public bool isCollected { get; set; }

    public void Interact()
    {
        // Implementation for Interact method
    }

    public void Break()
    {
        // Implementation for Break method
    }

    public void Collect()
    {
        // Implementation for Collect method
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
