﻿using System;


/// <summary> Player class </summary>
public class Player
{
    /// <summary> Players name </summary>
    protected string name;
    /// <summary> Players hp </summary>
    protected float hp;
    /// <summary> Players maxHp </summary>
    protected float maxHp;

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

    /// <summary>Method PrintHealth </summary>
    public void PrintHealth()
    {
        Console.WriteLine("{0} has {1} / {2} health", name, hp, maxHp);
    }

}