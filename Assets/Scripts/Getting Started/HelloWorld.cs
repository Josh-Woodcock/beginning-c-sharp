using UnityEngine;

public class HelloWorld : MonoBehaviour {

    public string gameName;
    public int price;
    public string anotherGameName;
    public int score;
    public double myDouble = 10.1;
    public float myFloat = (float) 10.1;
    public bool likesGame = false;

    // This is for demonstration // 
    public byte overflowError = 255;



    void OnEnable() {
        Debug.Log("Hello World");

    }

    void OnDisable() {
        /**
        Debug.Log("The game " + gameName + " is " + price + " dollars.");
        Debug.Log("The game " + anotherGameName + " has the score " + score);
        **/

        overflowError = (byte) (overflowError + 3);
        Debug.Log("The result of the overflow error is: " + overflowError);

    }

}