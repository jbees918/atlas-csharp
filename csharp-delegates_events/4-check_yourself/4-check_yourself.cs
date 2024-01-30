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
        this.name = name;
        if( maxHp <= 0f){
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            maxHp = 100f;
        }
        this.maxHp = maxHp;
        this.hp = this.maxHp;
        this.status = String.Format("{0} is ready to go!", name);
        HPCheck += CheckStatus;
    }

    /// <summary> Print Health Method </summary>
    public void PrintHealth()
    {
        Console.WriteLine("{0} has {1} / {2} health", name, hp, maxHp);
    }

    /// <summary> Take Damage Method </summary>
    public void TakeDamage(float damage)
    {
        if( damage < 0f)
            damage = 0f;
        Console.WriteLine("{0} takes {1} damage!", name, damage);
        ValidateHP(hp - damage);
    }

    /// <summary> Heal Damage Method </summary>
    public void HealDamage(float heal)
    {
        if( heal < 0f)
            heal = 0f;
        Console.WriteLine("{0} heals {1} HP!", name, heal);
        ValidateHP(hp + heal);
    }

    /// <summary> Validate Health Method </summary>
    public void ValidateHP(float newHp)
    {
        hp = Math.Clamp(newHp, 0, maxHp);
        HPCheck(this, new CurrentHPArgs(this.hp));
    }

    /// <summary> Check Status Method </summary>
    public void CheckStatus(object sender, CurrentHPArgs e)
    {
        float state = e.currentHp/maxHp;
        if (state == 1)
            status = String.Format("{0} is in perfect health!", name);
        else if (state >=0.5f)
            status = String.Format("{0} is doing well!", name);
        else if (state >=0.25f)
            status = String.Format("{0} isn't doing too great...", name);
        else if (state >0f)
            status = String.Format("{0} needs help!", name);
        else
            status = String.Format("{0} is knocked out!", name);

        Console.WriteLine(status);
    }
}
