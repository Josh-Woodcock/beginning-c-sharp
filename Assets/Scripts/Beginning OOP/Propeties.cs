using System.Collections;
using System.Collections.Generic;
using UnityEngine;

struct BadGuy
{
    private int pointValue;
    public int Bonus;
    public int PointValue
    {
        get
        {
            return pointValue + Bonus;
        }
        set
        {
            if (value > 0)
            {
                pointValue = value;
            }
            else
            {
                pointValue = 0;
            }
            Debug.Log("did set");
        }
    }
}

public class Propeties : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        
	}

    void OnDisable ()
    {
        BadGuy badguy = new BadGuy();
        badguy.PointValue = 100;
        Debug.Log(" The bad guy is worth " + badguy.PointValue + " points");
    }
}
