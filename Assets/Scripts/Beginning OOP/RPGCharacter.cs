using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct RPGCharacter
{
    public string Name { get; set; }
    public int Strength { get; set; }
    public int Intelligence { get; set; }
    public int Dexterity { get; set; }

    public RPGCharacter(string name, int strength, int intelligence, int dexterity)
    {
        this.Name = name;
        this.Strength = strength;
        this.Intelligence = intelligence;
        this.Dexterity = dexterity;
    }

    private RPGCharacter(string name)
    {
        this.Name = name;
        this.Strength = Random.Range(0, 18);
        this.Intelligence = Random.Range(0, 18);
        this.Dexterity = Random.Range(0, 18);
    
    }

    public static RPGCharacter GetRandomCHaracter(string name)
    {
        return new RPGCharacter(name);
    }

    public string GetCharacterStats()
    {
        string characterStats = " ";
        characterStats += "Name " + this.Name + " ";
        characterStats += "Strength " + this.Strength + " ";
        characterStats += "Intelligence " + this.Intelligence + " ";
        characterStats += "Dexterity " + this.Dexterity + " ";
        return characterStats;
    }
}