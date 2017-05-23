using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy {

    protected int hitPoints;
    public enum DamageType { Water, Fire };

    public virtual void TakeDamage(int amount, DamageType damageType)
    {
        hitPoints -= amount;
    }

    public string GetHitPoints()
    {
        return " " + hitPoints;
    }
}

class WaterEnemy : Enemy
{
    public WaterEnemy()
    {
        hitPoints = 30;
    }


    public override void TakeDamage(int amount, DamageType damageType)
    {
       if (damageType == DamageType.Fire)
        {
            base.TakeDamage(amount * 2, damageType);
        }
       else
        {
            base.TakeDamage(amount / 2, damageType);
        }
    }
}

class FireEnemy : Enemy
{
    public override void TakeDamage(int amount, DamageType damageType)
    {
        if (damageType == DamageType.Fire)
        {
            base.TakeDamage(amount * 10, DamageType.Water);
        }
        else
        {
            base.TakeDamage(amount / 2, damageType);
        }
    }
}
