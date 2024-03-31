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
            hp -= damage;
            Console.WriteLine($"{name} takes {damage} damage!");
        } else {
            Console.WriteLine($"{name} takes 0 damage!");
        }
    }

    /// <summary>
    /// Rejuvenates player's HP.
    /// </summary>
    /// <param name="heal">The amount of HP to be healed.</param>
    public void HealDamage(float heal) {
        if (heal >= 0) {
            hp += heal;
            Console.WriteLine($"{name} heals {heal} HP!");
        } else {
            Console.WriteLine($"{name} heals 0 HP!");
        }
    }

    /// <summary>
    /// Prints the health of the player.
    /// </summary>
    public void PrintHealth() {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
}
