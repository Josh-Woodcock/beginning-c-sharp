using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class PC
{
    private string name = " ";
    private string twitter = " ";
    private string forumName = " ";

    public void SetPlayerInfo(string name)
    {
        this.name = name;
        Debug.Log("called with one string");
    }

    public void SetPlayerInfo(string name, string twitterHandle)
    {
        this.twitter = twitterHandle;
        Debug.Log("called with two strings");
        SetPlayerInfo(name);
    }

    public void SetPlayerInfo(string name, string twitter, string forumName)
    {
        this.forumName = forumName;
        Debug.Log("called with three strings");
        SetPlayerInfo(name, twitter);
    }
}

public class PlayerCharacter : MonoBehaviour {

    void OnDisable()
    {
        PC playerCharacter = new PC();
        playerCharacter.SetPlayerInfo("Josh","@JoshWoodcock", "hellisinhello");
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
