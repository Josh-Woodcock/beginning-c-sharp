using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoop : MonoBehaviour
{

    public int[] score;

    void OnDisable ()
    {
        for (int i=0; i < score.Length; i++)
        {
            Debug.Log("The " + i + " element is " + score[i]);
        }
    }

}

/* Update is called once per frame
   void OnDisable()

   {
       for (int i = 0; i < 10; i++)
       {
           if (i % 2 != 0)
           {
               continue;
           }
           for (int j = 0; j < 10; j++)
           {
               if (j % 2 != 0)
               {
                   continue;
               }
               Debug.Log(i + " + " + j + " = " + (i + j));

           }

       } */
