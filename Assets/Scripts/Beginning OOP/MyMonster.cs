using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMonster : MonoBehaviour {

    public int damage;
    private Monster monster;


	// Use this for initialization
	void Start ()
    {
        monster = new Monster();
        monster.SetHealth(100);
    }
	

    void OnDisable ()
    {
        monster.SetHealth(monster.GetHealth()- damage);
        if (monster.GetHealth() <= 0)
        {
            Debug.Log("The Monster is Dead");
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("The monster has " + monster.GetHealth() + " HP left. FINISH HIM!");
        }

    }

}
