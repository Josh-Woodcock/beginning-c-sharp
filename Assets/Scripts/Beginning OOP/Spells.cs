using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Spell
{
    string Name { get; set; }
    int Damage { get; set; }
    float DamageEffect { get; set; }

    public Spell(string name, int damage, float damageEffect)
    {
        this.Name = name;
        this.Damage = damage;
        this.DamageEffect = damageEffect;
    }

    public string GetSpellStats()
    {
        string spellStats = " ";
        spellStats += "Name: " + this.Name + " ";
        spellStats += "Damage: " + this.Damage + " ";
        spellStats += "Damage Effect: " + this.DamageEffect + " ";
        return spellStats;

    }

}
