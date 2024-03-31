using System;

///<summary>Base class representing an entity.</summary>
abstract class Base
{
    public string name = "";

    ///<summary>Returns a string representation of the entity.</summary>
    ///<returns>A string representing the name and type of the entity.</returns>
    public override string ToString()
    {
        return $"{name} is a {this.GetType().ToString()}";
    }
}

///<summary>Interactive interface</summary>
interface IInteractive
{
    ///<summary>Interacts with the object.</summary>
    void Interact();
}

///<summary>Breakable Interface</summary>
interface IBreakable
{
    ///<summary>The durability of the object.</summary>
    int durability { get; set; }

    ///<summary>Breaks the object.</summary>
    void Break();
}

///<summary>Collectable Interface</summary>
interface ICollectable
{
    ///<summary>Indicates whether the object has been collected.</summary>
    bool isCollected { get; set; }

    ///<summary>Collects the object.</summary>
    void Collect();
}

///<summary>Class that inherits from Base class and all interfaces</summary>
class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    ///<summary>The durability of the object.</summary>
    public int durability { get; set; }

    ///<summary>Indicates whether the object has been collected.</summary>
    public bool isCollected { get; set; }

    ///<summary>Interacts with the object.</summary>
    public void Interact()
    {
        // Implementation for Interact method
    }

    ///<summary>Breaks the object.</summary>
    public void Break()
    {
        // Implementation for Break method
    }

    ///<summary>Collects the object.</summary>
    public void Collect()
    {
        // Implementation for Collect method
    }
}
