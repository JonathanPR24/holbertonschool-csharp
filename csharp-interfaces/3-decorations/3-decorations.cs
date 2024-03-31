using System;

/// <summary>
/// Represents a decorative object within the game environment, providing interaction and breakable functionalities. 
/// </summary>
class Decoration : Base, IInteractive, IBreakable {
    public bool isQuestItem { get; set; }
    public int durability { get; set; }  

    /// <summary>
    /// Initializes a new instance of the <see cref="Decoration"/> class with default values.
    /// </summary>
    /// <param name="name">The name of the decoration.</param>
    /// <param name="durability">The durability of the decoration.</param>
    /// <param name="isQuestItem">Indicates if the decoration is a quest item.</param>
    public Decoration(string name = "Decoration", int durability = 1,
                       bool isQuestItem = false) {

        if (durability <= 0) {
            throw new Exception("Durability must be greater than 0");
        } else {
            this.name = name;
            this.durability = durability;
            this.isQuestItem = isQuestItem;
        }

    }

    /// <summary>
    /// Interact with the decoration object.
    /// </summary>
    public void Interact() {

        if (durability <= 0) {
            Console.WriteLine($"The {name} has been broken.");
        } else if (isQuestItem == true) {
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        } else {
            Console.WriteLine($"You look at the {name}. Not much to see here.");
        }

    }

    /// <summary>
    /// Simulates breaking the decoration object.
    /// </summary>
    public void Break() {

        durability--;

        if (durability > 0) {
            Console.WriteLine($"You hit the {name}. It cracks.");
        } else if (durability == 0) {
            Console.WriteLine($"You smash the {name}. What a mess.");
        } else {
            Console.WriteLine($"The {name} is already broken.");
        }

    }
}


/// <summary>
/// Represents an interactable door object within the game environment.
/// </summary>
class Door : Base, IInteractive {

    /// <summary>
    /// Initializes a new instance of the <see cref="Door"/> class with the specified name.
    /// </summary>
    /// <param name="_name">The name of the door.</param>
    public Door(string _name = "Door") {
        name = _name;
    }

    /// <summary>
    /// Simulates interaction with the door object.
    /// </summary>
    public void Interact() {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }

}

/// <summary>
/// A base class providing common properties and methods.
/// </summary>
abstract class Base {

    /// <summary>
    /// Gets or sets the name of the object.
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// Converts the object to its string representation.
    /// </summary>
    /// <returns>A string representing the object.</returns>
    public override string ToString() {
        return $"{name} is a {this.GetType()}";
    }

}

/// <summary>
/// Interface defining an interactable object.
/// </summary>
public interface IInteractive {

    /// <summary>
    /// Interacts with the object.
    /// </summary>
    void Interact();

}

/// <summary>
/// Interface defining a breakable object.
/// </summary>
public interface IBreakable {

    /// <summary>
    /// Gets or sets the durability of the breakable object.
    /// </summary>
    int durability { get; set; }

    /// <summary>
    /// Simulates breaking the object.
    /// </summary>
    void Break();

}

/// <summary>
/// Interface defining a collectable object.
/// </summary>
public interface ICollectable {

    /// <summary>
    /// Gets or sets a value indicating whether the object has been collected.
    /// </summary>
    bool isCollected { get; set; }

    /// <summary>
    /// Simulates collecting the object.
    /// </summary>
    void Collect();

}
