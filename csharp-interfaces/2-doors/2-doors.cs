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

///<summary>Class representing a door.</summary>
class Door : Base, IInteractive
{
    ///<summary>Constructor for Door class.</summary>
    ///<param name="name">The name of the door. Default value is "Door" if not provided.</param>
    public Door(string name = "Door")
    {
        this.name = name;
    }

    ///<summary>Method invoked when interacting with the door.</summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {this.name}. It's locked.");
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
