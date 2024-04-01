using System;

public enum Modifier {
    Weak,
    Base,
    Strong
}

public delegate float CalculateModifier(float baseValue, Modifier modifier);

public class Player
{
    string name { get; set; }
    float maxHp { get; set; }
    float hp { get; set; }

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

    public void TakeDamage(float damage) {
        if (damage >= 0) {
            Console.WriteLine($"{name} takes {damage} damage!");
            ValidateHP(hp - damage);
        } else {
            Console.WriteLine($"{name} takes 0 damage!");
        }
    }

    public void HealDamage(float heal) {
        if (heal >= 0) {
            Console.WriteLine($"{name} heals {heal} HP!");
            ValidateHP(hp + heal);
        } else {
            Console.WriteLine($"{name} heals 0 HP!");
        }
    }

    public float ApplyModifier(float baseValue, Modifier modifier) {
        switch (modifier) {
            case Modifier.Weak:
                return baseValue / 2f;
            case Modifier.Base:
                return baseValue;
            case Modifier.Strong:
                return baseValue * 1.5f;
            default:
                return baseValue;
        }
    }

    public void ValidateHP(float newHp) {
        if (newHp < 0 ) {
            newHp = 0;
        }
        if (newHp > maxHp) {
            newHp = maxHp;
        }
        hp = newHp;
    }

    public void PrintHealth() {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("Electric Mouse");
        CalculateModifier mod = new CalculateModifier(player.ApplyModifier);

        player.PrintHealth();

        player.TakeDamage(mod(50f, Modifier.Weak));

        player.PrintHealth();

        player.HealDamage(mod(10f, Modifier.Strong));

        player.PrintHealth();
    }
}
