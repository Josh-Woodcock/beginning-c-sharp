using UnityEngine;

public class Operators : MonoBehaviour {

    public int value = 0;

    void Start ()
    {

    }
	
	void OnDisable () {

        Debug.Log("value is " + value % 2);

        /**
        int x = ((100 / 4) * 20) + (3 * 2);
        Debug.Log("x is " + x);
		**/
	}
}
