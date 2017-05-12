using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Methods : MonoBehaviour {


    public int goldAmount;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnDisable () {
        NPC myNpc = new NPC();
        myNpc.Talk();

        myNpc.SetGold(goldAmount);
        Debug.Log(myNpc.GetGold());

    }
}
