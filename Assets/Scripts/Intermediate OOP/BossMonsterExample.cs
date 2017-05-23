using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMonsterExample : MonoBehaviour {

    BossMonster boss = null;
    BossMonster sameBoss = null;

	// Use this for initialization
	void Start () {
        boss = new BossMonster("Freddy", 100);
        sameBoss = boss;
        boss = null;

		
	}
	
	// Update is called once per frame
	void OnDisable () {
        sameBoss = null;
		
	}
}
