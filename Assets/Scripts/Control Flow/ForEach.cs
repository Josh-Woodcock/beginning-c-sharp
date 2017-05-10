using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEach : MonoBehaviour {

    int[] luckyNumbers = { 33, 56, 3, 12, 7, 23, 22, 0 };

    void OnDisable ()
    {
        foreach (int number in luckyNumbers)
        {
            if (number == 0)
            {
                continue;
            }

            Debug.Log(number);
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
