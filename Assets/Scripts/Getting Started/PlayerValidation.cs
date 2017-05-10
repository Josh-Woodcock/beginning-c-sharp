using UnityEngine;

public class PlayerValidation : MonoBehaviour {

    public string playerName;

	void OnDisable () {
        string result;
        result = (playerName != "") ? "Hello, " + playerName : "Hello, Player One";
        Debug.Log(result);
	}
}
