using System;

public abstract class Base
{
    protected string name { get; set; } = "";

    public override string ToString()
    {
        return $"{name} is a {this.GetType()}";
    }
}

public interface IInteractive
{
    void Interact();
}

public interface IBreakable
{
    int durability { get; set; }
    void Break();
}

public interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability { get; set; }
    public bool isCollected { get; set; }

    public void Interact()
    {
        // Method implementation.
    }

    public void Break()
    {
        // Method implementation.
    }

    public void Collect()
    {
        // Method implementation.
    }
}
