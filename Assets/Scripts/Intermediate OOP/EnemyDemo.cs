using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDemo : MonoBehaviour {

	void OnDisable()
    {
        WaterEnemy waterEnemy = new WaterEnemy();
        waterEnemy.TakeDamage(10, Enemy.DamageType.Fire);
        Debug.Log(waterEnemy.GetHitPoints());
    }
    
    
    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
