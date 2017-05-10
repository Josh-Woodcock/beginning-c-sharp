using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FavouriteGamesWhileLoop : MonoBehaviour {

    public string[] favouriteGames;

    void OnDisable ()
    {
        int i = 0;
        while (i < favouriteGames.Length)
        {
            Debug.Log(favouriteGames[i]);
            i += 1;
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
