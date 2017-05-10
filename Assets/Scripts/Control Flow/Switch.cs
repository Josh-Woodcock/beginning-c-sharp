using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {

    public int playerCount;

    void OnDisable ()
    {
        switch (playerCount)
        {
             case 1:
                Debug.Log("Hello PLayer One");
                break;
            case 2:
                Debug.Log("Hello Players");
                break;
           default:
                Debug.Log("Please enter 1 or 2 players");
                break;
        }
           
       
    }
}
