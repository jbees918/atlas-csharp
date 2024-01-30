﻿using System;


/// <summary> Player class </summary>
public class Player
{
    /// <summary> Player's name </summary>
    protected string name;
    /// <summary> Player's maxHp </summary>
    protected float hp;
    protected float maxHp;
    /// <summary> Player's hp </summary>

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
    }

    /// <summary>The PrintHealth Method </summary>
    public void PrintHealth()
    {
        Console.WriteLine("{0} has {1} / {2} health", name, hp, maxHp);
    }

}