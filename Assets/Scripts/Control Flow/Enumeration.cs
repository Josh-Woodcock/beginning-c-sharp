using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enumeration : MonoBehaviour {

    public enum Direction { Up = 1, Down = -1 };
    public Direction playerMovement;

    void OnDisable ()
    {
        float yMovement = 10.0f;
        yMovement *= (int)playerMovement;
        Debug.Log(yMovement);
    }



	// Use this for initialization
	void Start () {
       
    
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
