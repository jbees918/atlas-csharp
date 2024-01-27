using system;

public class Player
{
    private float maxHp;
    private string name;
    private float hp;

    /// <summary>
    /// Creates new Player.
    /// </summary>
    /// <param name="name">Player name.</param>
    /// <param name="maxHp">Max health points of player. Must be greater than 0. Default is 100f.</param>
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

    /// <summary>
    /// Print player health.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
}
