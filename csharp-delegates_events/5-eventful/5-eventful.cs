using System;

/// <summary> Current Health Arguments </summary>
public class CurrentHPArgs : EventArgs
{
    /// <summary> Current HP </summary>
    public float currentHp { get; }

    /// <summary> Current HP Arguments Constructor </summary>
    public CurrentHPArgs(float newHp)
    {
        currentHp = newHp;
    }
}

/// <summary> Player class </summary>
public class Player
{
    /// <summary> Player name </summary>
    protected string name;
    /// <summary> Player maxHp </summary>
    protected float maxHp;
    /// <summary> Player hp </summary>
    protected float hp;
    /// <summary> Player status </summary>
    private string status;

    /// <summary> HP Check Event </summary>
    public event EventHandler<CurrentHPArgs> HPCheck;

    /// <summary> Player Constructor </summary>
    public Player(string name="Player", float maxHp=100f)
    {
        if( maxHp <= 0f){
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            maxHp = 100f;
        }
        this.name = name;
        this.maxHp = maxHp;
        this.hp = this.maxHp;
        this.status = $"{name} is ready to go!";
        HPCheck += CheckStatus;
    }

    /// <summary> Print Health Method </summary>
    public void PrintHealth()
    {
        Console.WriteLine("{0} has {1} / {2} health", name, hp, maxHp);
    }

    /// <summary>Method Check Status </summary>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == maxHp)
        {
            status = $"{name} is in perfect health!";
        }
        else if (e.currentHp >= maxHp * 0.5f && e.currentHp < maxHp)
        {
            status = $"{name} is doing well!";
        }
        else if (e.currentHp >= maxHp * 0.25f && e.currentHp < maxHp * 0.5f)
        {
            status = $"{name} isn't doing too great...";
        }
        else if (e.currentHp > 0 && e.currentHp < maxHp * 0.25f)
        {
            status = $"{name} needs help!";
        }
        else if (e.currentHp == 0)
        {
            status = $"{name} is knocked out!";
        }
        Console.WriteLine(status);
    }

    /// <summary> HP Value Warning Method </summary>
    private void HPValueWarning(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Health has reached zero!");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Health is low!");
            Console.ResetColor();
        }
    }

    /// <summary> On Check Status Method </summary>
    public void OnCheckStatus(CurrentHPArgs e)
    {
        if (e.currentHp < maxHp * 0.25f)
        {
            HPCheck -= CheckStatus;
            HPCheck += HPValueWarning;
        }
        HPCheck?.Invoke(this, e);
    }

    /// <summary> Validate Health Method </summary>
    public void ValidateHP()
    {
        OnCheckStatus(new CurrentHPArgs(hp));
    }
}
