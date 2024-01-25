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
}
