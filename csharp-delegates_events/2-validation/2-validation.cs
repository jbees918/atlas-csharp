using System;

/// <summary> Player class </summary>
public class Player
{
    /// <summary> Player name </summary>
    private string playerName;
    /// <summary> Player maxHp </summary>
    private float playerMaxHp;
    /// <summary> Player hp </summary>
    private float playerHp;

    /// <summary> Player delegate </summary>
    public delegate void CalculateHealth(float amount);

    /// <summary> Player Constructor </summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        playerName = name;
        if (maxHp <= 0f)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            maxHp = 100f;
        }
        playerMaxHp = maxHp;
        playerHp = playerMaxHp;
    }

    /// <summary> PrintHealth Method </summary>
    public void PrintHealth()
    {
        Console.WriteLine("{0} has {1} / {2} health", playerName, playerHp, playerMaxHp);
    }

    /// <summary> TakeDamage Method </summary>
    public void TakeDamage(float damage)
    {
        if (damage < 0f)
            damage = 0f;
        Console.WriteLine("{0} takes {1} damage!", playerName, damage);
        ValidateHealth(playerHp - damage);
    }

    /// <summary> HealDamage Method </summary>
    public void HealDamage(float heal)
    {
        if (heal < 0f)
            heal = 0f;
        Console.WriteLine("{0} heals {1} HP!", playerName, heal);
        ValidateHealth(playerHp + heal);
    }

    /// <summary> Validates HP </summary>
    private void ValidateHealth(float newHp)
    {
        playerHp = Math.Clamp(newHp, 0, playerMaxHp);
    }
}
