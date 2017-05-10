using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FavouriteGames : MonoBehaviour {

    public string[] favouriteGames;

    void OnDisable ()
    {
        foreach(string game in favouriteGames)
        {
            Debug.Log(game);
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
