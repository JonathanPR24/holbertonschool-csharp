using System;

public class Player
{
    private string name;
    private float maxHp;
    private float hp;

    public Player(string name, float maxHp)
    {
        this.name = name;
        if (maxHp <= 0)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            maxHp = 100f;
        }
        this.maxHp = maxHp;
        this.hp = maxHp;
    }

    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Player player1 = new Player("Electric Mouse", 500f);
        Player player2 = new Player("Water Turtle");

        player1.PrintHealth();
        player2.PrintHealth();
    }
}
