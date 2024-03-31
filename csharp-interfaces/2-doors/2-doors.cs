using System;

/// <summary>
/// A base class.
/// </summary>
abstract class Base
{
    public string name { get; set; }

    /// <summary>
    /// Constructor for the base class.
    /// </summary>
    public Base(string _name = "Door")
    {
        name = _name;
    }

    /// <summary>
    /// Convert the object to a string.
    /// </summary>
    public override string ToString()
    {
        return $"{name} is a {GetType()}";
    }
}

/// <summary>
/// Interface defining an interactable object.
/// </summary>
public interface IInteractive
{
    /// <summary>
    /// Interact with this object.
    /// </summary>
    void Interact();
}

/// <summary>
/// Represents a door that can be interacted with.
/// </summary>
class Door : Base, IInteractive
{
    public Door(string _name = "Door") : base(_name)
    {
    }

    /// <summary>
    /// Interact with the door.
    /// </summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Door frontDoor = new Door("Front Door");

        Console.WriteLine(frontDoor.ToString());

        frontDoor.Interact();
    }
}
