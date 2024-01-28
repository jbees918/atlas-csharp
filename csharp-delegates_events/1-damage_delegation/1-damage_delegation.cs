using System;

public delegate void CalculateHealth(float amount);

public class Player
{
    private float maxHp;
    private string name;
    private float hp;

    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0)
        {
            maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }

        this.name = name;
        this.maxHp = maxHp;
        this.hp = maxHp;
    }

    public void TakeDamage(float damage)
    {
        if (damage >= 0)
        {
            hp -= damage;
            Console.WriteLine($"{name} takes {damage} damage!");
        }
        else
        {
            Console.WriteLine($"{name} takes 0 damage!");
        }
    }

    public void HealDamage(float heal)
    {
        if (heal >= 0)
        {
            hp += heal;
            Console.WriteLine($"{name} heals {heal} HP!");
        }
        else
        {
            Console.WriteLine($"{name} heals 0 HP!");
        }
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
        Player player = new Player("Electric Mouse");

        CalculateHealth damage = player.TakeDamage;
        damage(25f);

        CalculateHealth heal = player.HealDamage;
        heal(10f);

        damage(-25f);
    }
}