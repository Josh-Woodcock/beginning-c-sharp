using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leaderboard : MonoBehaviour
{
    public string[] players;
    public int[] scores;

    void OnDisable()

    {
        for (int i = 0; i < players.Length; i++)
        {
            Debug.Log(players[i] + " scored " + scores[i] + " points.");

        }

    }

}

