using System;

/// <summary>
/// Represents a decoration object that can be interacted with and broken.
/// </summary>
class Decoration : Base, IInteractive, IBreakable
{
    public int durability { get; set; }
    public bool isQuestItem { get; set; }

    /// <summary>
    /// Constructor for the Decoration class.
    /// </summary>
    /// <param name="name">The name of the decoration.</param>
    /// <param name="durability">The durability of the decoration.</param>
    /// <param name="isQuestItem">Indicates if the decoration is a quest item.</param>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
        {
            throw new ArgumentException("Durability must be greater than 0");
        }

        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    /// <summary>
    /// Interact with the decoration.
    /// </summary>
    public void Interact()
    {
        if (durability <= 0)
        {
            Console.WriteLine($"The {name} has been broken.");
            return;
        }

        if (isQuestItem)
        {
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        }
        else
        {
            Console.WriteLine($"You look at the {name}. Not much to see here.");
        }
    }

    /// <summary>
    /// Break the decoration.
    /// </summary>
    public void Break()
    {
        if (durability > 0)
        {
            durability--;

            if (durability > 0)
            {
                Console.WriteLine($"You hit the {name}. It cracks.");
            }
            else
            {
                Console.WriteLine($"You smash the {name}. What a mess.");
            }
        }
        else
        {
            Console.WriteLine($"The {name} is already broken.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Decoration coffeeMug = new Decoration("Coffee Mug", 2);

        Console.WriteLine(coffeeMug.ToString());

        coffeeMug.Interact();
        coffeeMug.Break();
        coffeeMug.Break();
        coffeeMug.Interact();
    }
}
