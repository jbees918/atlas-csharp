using System;

/// <summary>
/// Player class. Represents a player.
/// </summary>
public class Player
{
    private string name;
    private float maxHp;
    private float hp;

    /// <summary>
    /// Player constructor. Sets up new player.
    /// </summary>
    /// <param name="name">Name of player. Defaults to "Player" if not given.</param>
    /// <param name="maxHp">Maximum HP of player. Needs to be more than 0. Defaults to 100f if not given or less than or equal to 0.</param>
    public Player(string name, float maxHp)
    {
        this.name = name ?? "Player";
        this.maxHp = maxHp > 0 ? maxHp : 100f;
        this.hp = this.maxHp;
    }

    /// <summary>
    /// Prints player's name and current health.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    /// <summary>
    /// Delegate for calculating health.
    /// </summary>
    /// <param name="amount">Amount of health to calculate.</param>
    public delegate void CalculateHealth(float amount);

    /// <summary>
    /// Player takes damage.
    /// </summary>
    /// <param name="damage">Amount of damage taken.</param>
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

    /// <summary>
    /// Player heals damage.
    /// </summary>
    /// <param name="heal">Amount of damage healed.</param>
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
}
