using System;

delegate void CalculateHealth(float value);

/// <summary>
/// Represents a character in the game.
/// </summary>
public class Player
{
    string name { get; set; }
    float maxHp { get; set; }
    float hp { get; set; }

    /// <summary>
    /// Initializes a new instance of the Player class.
    /// </summary>
    /// <param name="name">The name of the player.</param>
    /// <param name="maxHp">The maximum health points of the player.</param>
    public Player(string name = "Player", float maxHp = 100f) {
        this.name = name;

        if (maxHp > 0) {
            this.maxHp = maxHp;
        } else {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        this.hp = this.maxHp;
    }

    /// <summary>
    /// Applies damage to the player.
    /// </summary>
    /// <param name="damage">The amount of damage to be applied.</param>
    public void TakeDamage(float damage) {
        if (damage >= 0) {
            Console.WriteLine($"{name} takes {damage} damage!");
        } else {
            Console.WriteLine($"{name} takes 0 damage!");
        }
        ValidateHP(hp - damage);
    }

    /// <summary>
    /// Rejuvenates player's HP.
    /// </summary>
    /// <param name="heal">The amount of HP to be healed.</param>
    public void HealDamage(float heal) {
        if (heal >= 0) {
            Console.WriteLine($"{name} heals {heal} HP!");
        } else {
            Console.WriteLine($"{name} heals 0 HP!");
        }
        ValidateHP(hp + heal);
    }

    /// <summary>
    /// Sets the new value of the Player’s hp after validation.
    /// </summary>
    /// <param name="newHp">The new value of the player's hp.</param>
    public void ValidateHP(float newHp) {
        if (newHp < 0) {
            hp = 0;
        } else if (newHp > maxHp) {
            hp = maxHp;
        } else {
            hp = newHp;
        }
    }

    /// <summary>
    /// Prints the health of the player.
    /// </summary>
    public void PrintHealth() {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("Electric Mouse");

        player.PrintHealth();

        player.TakeDamage(50f);

        player.PrintHealth();

        player.HealDamage(49f);

        player.PrintHealth();
    }
}
