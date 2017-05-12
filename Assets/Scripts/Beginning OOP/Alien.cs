using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RayWenderlich.BeginingCSharp.Demonstartion
{
    struct Alien
    {
        public int HitPoints;
    }
}



public class Alien : MonoBehaviour {

    public Text playerName;



	// Use this for initialization
	void Start () {
        RayWenderlich.BeginingCSharp.Demonstartion.Alien alien = new RayWenderlich.BeginingCSharp.Demonstartion.Alien ();
        alien.HitPoints = 100; 
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
