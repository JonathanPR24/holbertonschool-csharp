using System;

interface IInteractive
{
    void Interact();
}

interface IBreakable
{
    int durability { get; set; }
    void Break();
}

interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    // Properties from IBreakable interface
    public int durability { get; set; }
    public void Break()
    {
        // Implementation not provided for this task
    }

    // Properties from ICollectable interface
    public bool isCollected { get; set; }
    public void Collect()
    {
        // Implementation not provided for this task
    }

    // Method from IInteractive interface
    public void Interact()
    {
        // Implementation not provided for this task
    }
}
