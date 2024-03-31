using System;

///<summary>Abstract base class representing an entity.</summary>
abstract class Base
{
    public string name = "";

    public override string ToString()
    {
        return (this.name + " is a " + this.GetType().ToString());
    }
}

///<summary>Interface for interactive objects.</summary>
interface IInteractive
{
    void Interact();
}

///<summary>Interface for breakable objects.</summary>
interface IBreakable
{
    int durability { get; set; }
    void Break();
}

///<summary>Interface for collectable objects.</summary>
interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

///<summary>Class representing a test object that inherits from Base class and all interfaces.</summary>
class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability { get; set; }
    public bool isCollected { get; set; }

    ///<summary>Method invoked when the object interacts with something.</summary>
    public void Interact()
    {

    }

    ///<summary>Method invoked when the object breaks.</summary>
    public void Break()
    {

    }

    ///<summary>Method invoked when the object is collected.</summary>
    public void Collect()
    {

    }
}
