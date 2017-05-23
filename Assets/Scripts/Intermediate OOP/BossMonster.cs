using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMonster{

    public string Name;
    public int Point;
    
    public BossMonster(string name, int point)
    {
        this.Name = name;
        this.Point = point;
    }

    ~BossMonster()
    {
        Debug.Log("Boss Monstyer destroyed");
    }
}
