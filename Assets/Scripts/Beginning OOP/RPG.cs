using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPG : MonoBehaviour {

    void OnDisable ()
    {
        RPGCharacter draco = new RPGCharacter("Draco", 10, 15, 6);
        Debug.Log(draco.GetCharacterStats());

        RPGCharacter randomNPC = RPGCharacter.GetRandomCHaracter("Jessica");
        Debug.Log(randomNPC.GetCharacterStats());
    }

   

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
