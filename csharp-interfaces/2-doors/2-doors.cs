using System;

/// <summary>
/// A base class.
/// </summary>
abstract class Base
{
    public string name { get; set; }

    /// <summary>
    /// Convert the object to a string.
    /// </summary>
    public override string ToString()
    {
        return $"{name} is a {this.GetType()}";
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
    /// <summary>
    /// Constructor for the Door class.
    /// </summary>
    /// <param name="name">The name of the door.</param>
    public Door(string name = "Door")
    {
        this.name = name;
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
