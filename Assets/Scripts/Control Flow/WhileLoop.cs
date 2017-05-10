using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoop : MonoBehaviour
{

    public int[] score;

    void OnDisable() {
        int i = 10;
        while (i < score.Length)
        {
            Debug.Log("The " + i + " element is " + score[i]);
            i += 1;
        }
        do
        {
            Debug.Log("The " + i + " element is " + score[i]);
            i += 1;
        } while (i < score.Length);
    }
  
}

