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
    /// Player constructor. Sets up a new player.
    /// </summary>
    /// <param name="name">Name of player. Defaults to "Player" if not given.</param>
    /// <param name="maxHp">Maximum HP of player. Needs to be more than 0. Defaults to 100f if not given or less than or equal to 0.</param>
    public Player(string name, float maxHp)
    {
        this.name = name ?? "Player";
        this.maxHp = maxHp > 0 ? maxHp : 100f;
        this.hp = this.maxHp;
        if (this.maxHp != maxHp)
        {
            Console.WriteLine("maxHp must be more than 0. maxHp set to 100f by default.");
        }
    }

    /// <summary>
    /// Prints player's name and current health.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
}
