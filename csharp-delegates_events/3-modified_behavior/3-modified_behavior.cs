using System;

delegate void CalculateHealth(float value);

/// <summary>
/// A delegate used to calculate modifiers for health values.
/// </summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
/// An enumeration of modifiers for adjusting health values.
/// </summary>
public enum Modifier {
    /// <summary>The weak modifier.</summary>
    Weak,
    /// <summary>The base modifier.</summary>
    Base,
    /// <summary>The strong modifier.</summary>
    Strong
}

/// <summary>
/// Represents a character in the game.
/// </summary>
public class Player
{
    string name { get; set; }
    float maxHp { get; set; }
    float hp { get; set; }

    /// <summary>
    /// Constructor for the player object.
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
            ValidateHP(hp - damage);
        } else {
            Console.WriteLine($"{name} takes 0 damage!");
        }
    }

    /// <summary>
    /// Rejuvenates player HP.
    /// </summary>
    /// <param name="heal">The amount of HP to be healed.</param>
    public void HealDamage(float heal) {

        if (heal >= 0) {
            Console.WriteLine($"{name} heals {heal} HP!");
            ValidateHP(hp + heal);
        } else {
            Console.WriteLine($"{name} heals 0 HP!");
        }
    }

    /// <summary>
    /// Apply modifier to incoming damage.
    /// </summary>
    /// <param name="baseValue">The base value to be modified.</param>
    /// <param name="modifier">The modifier to be applied.</param>
    /// <returns>The modified value.</returns>
    public float ApplyModifier(float baseValue, Modifier modifier) {

        if (modifier == Modifier.Weak) {
            return baseValue / 2f;
        }
        if (modifier == Modifier.Strong) {
            return baseValue * 1.5f;
        }
        return baseValue;
    }

    /// <summary>
    /// Validates player's new HP.
    /// </summary>
    /// <param name="newHp">The new value of the player's hp.</param>
    public void ValidateHP(float newHp) {

        if (newHp < 0 ) {
            newHp = 0;
        }
        if (newHp > maxHp) {
            newHp = maxHp;
        }

        hp = newHp;
    }

    /// <summary>
    /// Prints the health of the player.
    /// </summary>
    public void PrintHealth() {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

}
