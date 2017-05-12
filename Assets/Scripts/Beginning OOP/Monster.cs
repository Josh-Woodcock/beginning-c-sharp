using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Monster
{
    private int health;

    public int GetHealth()
    {
        return health;
    }

    public void SetHealth(int health)
    {
        this.health = health;
    }


}