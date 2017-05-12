using System.Collections;
using System.Collections.Generic;
using UnityEngine;

struct NPC
{
    private int gold;

    public void Talk()
    {
        Debug.Log(" blah blah blah");
    }

    public int GetGold() {
        return gold;
    }

    public void SetGold(int gold)
    {
        if (gold > 0)
        {
            this.gold = gold;
        }
    }
}
