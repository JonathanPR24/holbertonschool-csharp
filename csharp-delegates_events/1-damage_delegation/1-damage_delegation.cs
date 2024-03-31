using System;

public delegate void CalculateHealth(float amount);

public class Player
{
    public string name { get; set; }
    public float maxHp { get; set; }
    public float hp { get; set; }

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

    public void PrintHealth() {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    public void TakeDamage(float damage) {
        if (damage < 0) {
            damage = 0;
        }
        hp -= damage;
        Console.WriteLine($"{name} takes {damage} damage!");
    }

    public void HealDamage(float heal) {
        if (heal < 0) {
            heal = 0;
        }
        hp += heal;
        Console.WriteLine($"{name} heals {heal} HP!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("Electric Mouse");

        player.TakeDamage(25f);

        player.HealDamage(10f);

        player.TakeDamage(-25f);
    }
}
