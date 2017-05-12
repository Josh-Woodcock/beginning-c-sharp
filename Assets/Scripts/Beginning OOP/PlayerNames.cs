using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RayWenderlich.BeginingCSharp.Demonstartion
{
    struct PlayerNames
    {
        public string FirstName;
        public string LastName;
    }
}

namespace RayWenderlich.BeginingCSharp.Final
{
    struct InitScores
    {
        public string Initials;
        public int Score;
    }
}

public class PlayerNames : MonoBehaviour {

    public string firstName;
    public string lastName;
    public string initials;
    public int score;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnDisable ()
    {
        RayWenderlich.BeginingCSharp.Demonstartion.PlayerNames playerName = new RayWenderlich.BeginingCSharp.Demonstartion.PlayerNames();
        playerName.FirstName = firstName;
        playerName.LastName = lastName;

        Debug.Log("Your name is " + playerName.FirstName + " " + playerName.LastName);

        RayWenderlich.BeginingCSharp.Final.InitScores initScores = new RayWenderlich.BeginingCSharp.Final.InitScores();
        initScores.Initials = initials;
        initScores.Score = score;

        Debug.Log("Your initials are " + initScores.Initials + " " + "Your score is "+ initScores.Score);




    }

}
