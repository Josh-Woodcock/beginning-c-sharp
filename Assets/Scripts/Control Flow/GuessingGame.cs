using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuessingGame : MonoBehaviour {


    public int guess;
    private int randomNumber;

    // Use this for initialization
    void Start()
    {
        randomNumber = Random.Range(1, 10);
    }

    // Update is called once per frame
    void OnDisable () {
        if (guess >= 1 && guess <= 10)
        {
            if (guess == randomNumber)
            {
                Debug.Log("You guessed correct!");
            }
            else if (guess > randomNumber)
            {
                Debug.Log("You guessed too high!");
            }
            else {
                Debug.Log("You guessed too low!");
                    }
        }
        else
        {
            Debug.Log("Guess a number between 1 and 10");
        }
            
		
	}
}
