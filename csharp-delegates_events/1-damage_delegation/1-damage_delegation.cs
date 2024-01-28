using System;

public class Player
{
    private string playerName { get; set; }
    private float playerMaxHp { get; set; }
    public float playerHp { get; private set; }
    public delegate void CalculateHealth(float amount);

    public Player() : this("Player", 100f) { }
    public Player(string name) : this(name, 100f) { }
    public Player(float maxHp) : this("Player", maxHp) { }

    public Player(string name, float maxHp)
    {
        if (maxHp <= 0)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            maxHp = 100f;
        }
        playerName = name;
        playerMaxHp = maxHp;
        playerHp = maxHp;
    }

    public void PrintHealth()
    {
        Console.WriteLine($"{playerName} has {playerHp} / {playerMaxHp} health");
    }

    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            Console.WriteLine($"{playerName} takes 0 damage!");
        }
        else
        {
            Console.WriteLine($"{playerName} takes {damage} damage!");
        }
    }

    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            Console.WriteLine($"{playerName} heals 0 HP!");
        }
        else
        {
            Console.WriteLine($"{playerName} heals {heal} HP!");
        }
    }
}
