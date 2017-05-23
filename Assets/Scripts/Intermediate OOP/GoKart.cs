using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class GK
{
    private int speed;

    public void GetSpeed(int speed)
    {
        this.speed += speed;
        Debug.Log("The current speed is " + this.speed);
    }

    public void GetSpeed(int speed, bool turbo)
    {
        if (turbo == true)
        {
            GetSpeed(speed * 2);
        }
        else
        {
            GetSpeed(speed);
        }
    }
}


public class GoKart : MonoBehaviour {

    void OnDisable()
    {
        GK marioKart = new GK();
        marioKart.GetSpeed(10);
        marioKart.GetSpeed(5, true);
    }


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
